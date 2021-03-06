//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /Users/jessefreeman/Projects/DotNet/PixelBasic/PixelBasic/Antlr/PixelBasicExpression.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace PixelBasic {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="PixelBasicExpressionParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public interface IPixelBasicExpressionVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="PixelBasicExpressionParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProg([NotNull] PixelBasicExpressionParser.ProgContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PixelBasicExpressionParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStat([NotNull] PixelBasicExpressionParser.StatContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>AndExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAndExpr([NotNull] PixelBasicExpressionParser.AndExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>StringExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStringExpr([NotNull] PixelBasicExpressionParser.StringExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>MulDivExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMulDivExpr([NotNull] PixelBasicExpressionParser.MulDivExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>IdExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdExpr([NotNull] PixelBasicExpressionParser.IdExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>NumberExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumberExpr([NotNull] PixelBasicExpressionParser.NumberExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>RelExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRelExpr([NotNull] PixelBasicExpressionParser.RelExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>NotExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNotExpr([NotNull] PixelBasicExpressionParser.NotExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ParenExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParenExpr([NotNull] PixelBasicExpressionParser.ParenExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpExpr([NotNull] PixelBasicExpressionParser.ExpExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>FuncExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncExpr([NotNull] PixelBasicExpressionParser.FuncExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>AddSubExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAddSubExpr([NotNull] PixelBasicExpressionParser.AddSubExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>OrExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrExpr([NotNull] PixelBasicExpressionParser.OrExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PixelBasicExpressionParser.func"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunc([NotNull] PixelBasicExpressionParser.FuncContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PixelBasicExpressionParser.string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitString([NotNull] PixelBasicExpressionParser.StringContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PixelBasicExpressionParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumber([NotNull] PixelBasicExpressionParser.NumberContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PixelBasicExpressionParser.id"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitId([NotNull] PixelBasicExpressionParser.IdContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PixelBasicExpressionParser.lenfunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLenfunc([NotNull] PixelBasicExpressionParser.LenfuncContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PixelBasicExpressionParser.valfunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValfunc([NotNull] PixelBasicExpressionParser.ValfuncContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PixelBasicExpressionParser.isnanfunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsnanfunc([NotNull] PixelBasicExpressionParser.IsnanfuncContext context);
}
} // namespace PixelBasic
