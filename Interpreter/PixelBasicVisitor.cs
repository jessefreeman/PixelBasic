using Antlr4.Runtime;

namespace PixelBasic;

public class PixelBasicVisitor : PixelBasicBaseVisitor<Value>
{
    private MemoryStream stdin;
    private PrintStream stdout;
    private PrintStream stderr;
    private Memory memory;

    // private PrintStream printStream;
    // private BufferedReader inputStream;

    public PixelBasicVisitor(Memory memory, MemoryStream stdin)//, PrintStream stdout, PrintStream stderr) {
    {
        this.stdin = stdin;
        // this.stdout = stdout;
        // this.stderr = stderr;
        this.memory = memory;
    }

    // public override Value VisitProg(PixelBasicParser.ProgContext context)
    // {
    //     init();
    //     try {
    //         return base.VisitProg(context);
    //     } finally {
    //         cleanup();
    //     }
    // }
    //
    // private void init() {
    //     // printStream = new PrintStream(stdout, true);
    //     // inputStream = new BufferedReader(new InputStreamReader(stdin));
    // }
    //
    // private void cleanup() {
    //     // printStream.Close();
    // }

    public override Value VisitString(PixelBasicParser.StringContext context)
    {
        string value = context.GetText();
        return new Value(value.Substring(1, value.Length - 2)); // TODO had to make this 2 instead of 1 and not sure why
    }

    public override Value VisitNumber(PixelBasicParser.NumberContext context)
    {
        return new Value(Int32.Parse(context.GetText()));
    }
    
    public override Value VisitId(PixelBasicParser.IdContext context)
    {
        string id = context.GetText();
        return memory.get(id);
    }
    
    public override Value VisitLetstmt(PixelBasicParser.LetstmtContext context)
    {
        string varname = context.vardecl().varname().ID().GetText();
        Value value = Visit(context.expression());
        memory.assign(varname, value);
        return value;
    }

    public override Value VisitMulDivExpr(PixelBasicParser.MulDivExprContext context)
    {
        Value left = Visit(context.expression(0));
        Value right = Visit(context.expression(1));
        if (context.op.Type == PixelBasicExpressionParser.MUL) {
            return left.mul(right);
        } else if (context.op.Type == PixelBasicExpressionParser.DIV) {
            return left.div(right);
        } else {
            return left.mod(right);
        }
    }

    public override Value VisitAddSubExpr(PixelBasicParser.AddSubExprContext context)
    {
        Value left = Visit(context.expression(0));
        Value right = Visit(context.expression(1));
        if (context.op.Type == PixelBasicExpressionParser.ADD) {
            return left.add(right);
        } else {
            return left.sub(right);
        }
    }
    
    public override Value VisitLenfunc(PixelBasicParser.LenfuncContext context)
    {
        Value arg = Visit(context.expression());
        if (arg.isString()) {
            return new Value(arg.internalString().Length);
        } else {
            throw new TypeException("Couldn't evaluate LEN(). Argument is not a string");
        }
    }

    public override Value VisitValfunc(PixelBasicParser.ValfuncContext context)
    {
        Value arg = Visit(context.expression());
        if (arg.isString()) {
            string str = arg.internalString();
            try {
                return new Value(Int32.Parse(str));
            } catch (Exception e) { // TODO is there a specific exception for this?
                return Value.NaN;
            }
        }
        return arg;
    }

    public override Value VisitIsnanfunc(PixelBasicParser.IsnanfuncContext context)
    {
        Value arg = Visit(context.expression());
        return arg.isNaN() ? Value.TRUE : Value.FALSE;
    }

    public override Value VisitStatement(PixelBasicParser.StatementContext context)
    {
        try {
            return base.VisitStatement(context);
        } catch (TypeException e) {
            addLocation(e, context);

            throw e;
        }
    }

    public override Value VisitRelExpr(PixelBasicParser.RelExprContext context)
    {
        Value left = Visit(context.expression(0));
        Value right = Visit(context.expression(1));
        switch (context.op.Type) {
            case PixelBasicExpressionParser.GT:
                return left.gt(right);
            case PixelBasicExpressionParser.GTE:
                return left.gte(right);
            case PixelBasicExpressionParser.LT:
                return left.lt(right);
            case PixelBasicExpressionParser.LTE:
                return left.lte(right);
            case PixelBasicExpressionParser.EQ:
                return left.eq(right);
            default:
                return left.neq(right);
        }
    }
    
    private void addLocation(InterpreterException ex, ParserRuleContext ctx) {
        ex.SetLocation(ctx.Start.Line, ctx.Start.Column);
    }


    public override Value VisitNotExpr(PixelBasicParser.NotExprContext context)
    {
        Value value = Visit(context.expression());
        return value.not();
    }

    public override Value VisitAndExpr(PixelBasicParser.AndExprContext context)
    {
        Value left = Visit(context.expression(0));
        Value right = Visit(context.expression(1));
        return left.and(right);
    }

    public override Value VisitOrExpr(PixelBasicParser.OrExprContext context)
    {
        Value left = Visit(context.expression(0));
        Value right = Visit(context.expression(1));
        return left.or(right);
    }

    public override Value VisitExpExpr(PixelBasicParser.ExpExprContext context)
    {
        Value left = Visit(context.expression(0));
        Value right = Visit(context.expression(1));
        // TODO which one is left and which is right ?
        return left.exp(right);
    }
    
    public override Value VisitIfstmt(PixelBasicParser.IfstmtContext context) {
        Value condition = Visit(context.expression());
        if (condition.isTrue()) {
            return Visit(context.block());
        } else {
            foreach(PixelBasicParser.ElifstmtContext elifCtx in context.elifstmt()) {
                condition = Visit(elifCtx.expression());
                if (condition.isTrue()) {
                    return Visit(elifCtx.block());
                }
            }
            if (context.elsestmt() != null) {
                return Visit(context.elsestmt().block());
            }
        }
        return condition;
    }

    public override Value VisitPrintstmt(PixelBasicParser.PrintstmtContext context)
    {
        Value value = Visit(context.expression());
        if (value.isNumber()) {
            Console.WriteLine(value.internalNumber());
            // printStream.println(value.internalNumber());
        } else {
            Console.WriteLine(value.internalString());

            // printStream.println(value.internalString());
        }
        return value;
    }

    public override Value VisitInputstmt(PixelBasicParser.InputstmtContext context)
    {
        // printStream.print(visit(ctx.string()).internalString() + " ");
        // string varname = ctx.vardecl().getText();
        // try {
        //     string line = inputStream.readLine();
        //     Value val = new Value(line);
        //     memory.assign(varname, val);
        //     return val;
        // } catch (IOException e) {
        //     throw new RuntimeException(e); // TODO
        // }
        
        throw new NotImplementedException();
    }

    public override Value VisitForstmt(PixelBasicParser.ForstmtContext context)
    {
        string varname = context.vardecl().varname().ID().GetText();
        Value start = Visit(context.expression(0));
        Value end = Visit(context.expression(1));
        Value step = context.expression(2) != null ? Visit(context.expression(2)) : new Value(1);
        for (int i = start.internalNumber(); i <= end.internalNumber(); i = i + step.internalNumber()) {
            memory.assign(varname, new Value(i));
            try {
                Visit(context.block());
            } catch (ContinueLoopException e) {
                continue;
            } catch (ExitLoopException e) {
                break;
            }
        }
        return new Value(0);
    }

    public override Value VisitWhilestmt(PixelBasicParser.WhilestmtContext context)
    {
        Value cond = Visit(context.expression());
        while (cond.isTrue()) {
            try {
                Visit(context.block());
            } catch (ContinueLoopException e) {
                continue;
            } catch (ExitLoopException e) {
                break;
            } finally {
                cond = Visit(context.expression());
            }
        }
        return new Value(0);
    }

    public override Value VisitRepeatstmt(PixelBasicParser.RepeatstmtContext context)
    {
        Value cond;
        do {
            try {
                Visit(context.block());
            } catch (ContinueLoopException e) {
                continue;
            } catch (ExitLoopException e) {
                break;
            } finally {
                cond = Visit(context.expression());
            }
        } while (cond.isFalse());
        return new Value(0);
    }

    public override Value VisitContinuestmt(PixelBasicParser.ContinuestmtContext context)
    {
        throw new ContinueLoopException();
    }

    public override Value VisitExitstmt(PixelBasicParser.ExitstmtContext context)
    {
        throw new ExitLoopException();
    }
}