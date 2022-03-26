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
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IPixelBasicExpressionListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class PixelBasicExpressionBaseListener : IPixelBasicExpressionListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="PixelBasicExpressionParser.prog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProg([NotNull] PixelBasicExpressionParser.ProgContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PixelBasicExpressionParser.prog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProg([NotNull] PixelBasicExpressionParser.ProgContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PixelBasicExpressionParser.stat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStat([NotNull] PixelBasicExpressionParser.StatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PixelBasicExpressionParser.stat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStat([NotNull] PixelBasicExpressionParser.StatContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>AndExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAndExpr([NotNull] PixelBasicExpressionParser.AndExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AndExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAndExpr([NotNull] PixelBasicExpressionParser.AndExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>StringExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStringExpr([NotNull] PixelBasicExpressionParser.StringExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>StringExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStringExpr([NotNull] PixelBasicExpressionParser.StringExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>MulDivExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMulDivExpr([NotNull] PixelBasicExpressionParser.MulDivExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>MulDivExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMulDivExpr([NotNull] PixelBasicExpressionParser.MulDivExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>IdExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdExpr([NotNull] PixelBasicExpressionParser.IdExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>IdExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdExpr([NotNull] PixelBasicExpressionParser.IdExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>NumberExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumberExpr([NotNull] PixelBasicExpressionParser.NumberExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>NumberExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumberExpr([NotNull] PixelBasicExpressionParser.NumberExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>RelExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRelExpr([NotNull] PixelBasicExpressionParser.RelExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>RelExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRelExpr([NotNull] PixelBasicExpressionParser.RelExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>NotExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNotExpr([NotNull] PixelBasicExpressionParser.NotExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>NotExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNotExpr([NotNull] PixelBasicExpressionParser.NotExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ParenExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParenExpr([NotNull] PixelBasicExpressionParser.ParenExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ParenExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParenExpr([NotNull] PixelBasicExpressionParser.ParenExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ExpExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpExpr([NotNull] PixelBasicExpressionParser.ExpExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExpExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpExpr([NotNull] PixelBasicExpressionParser.ExpExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>FuncExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFuncExpr([NotNull] PixelBasicExpressionParser.FuncExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>FuncExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFuncExpr([NotNull] PixelBasicExpressionParser.FuncExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>AddSubExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAddSubExpr([NotNull] PixelBasicExpressionParser.AddSubExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AddSubExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAddSubExpr([NotNull] PixelBasicExpressionParser.AddSubExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>OrExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOrExpr([NotNull] PixelBasicExpressionParser.OrExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>OrExpr</c>
	/// labeled alternative in <see cref="PixelBasicExpressionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOrExpr([NotNull] PixelBasicExpressionParser.OrExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PixelBasicExpressionParser.func"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunc([NotNull] PixelBasicExpressionParser.FuncContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PixelBasicExpressionParser.func"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunc([NotNull] PixelBasicExpressionParser.FuncContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PixelBasicExpressionParser.string"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterString([NotNull] PixelBasicExpressionParser.StringContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PixelBasicExpressionParser.string"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitString([NotNull] PixelBasicExpressionParser.StringContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PixelBasicExpressionParser.number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumber([NotNull] PixelBasicExpressionParser.NumberContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PixelBasicExpressionParser.number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumber([NotNull] PixelBasicExpressionParser.NumberContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PixelBasicExpressionParser.id"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterId([NotNull] PixelBasicExpressionParser.IdContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PixelBasicExpressionParser.id"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitId([NotNull] PixelBasicExpressionParser.IdContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PixelBasicExpressionParser.lenfunc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLenfunc([NotNull] PixelBasicExpressionParser.LenfuncContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PixelBasicExpressionParser.lenfunc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLenfunc([NotNull] PixelBasicExpressionParser.LenfuncContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PixelBasicExpressionParser.valfunc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterValfunc([NotNull] PixelBasicExpressionParser.ValfuncContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PixelBasicExpressionParser.valfunc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitValfunc([NotNull] PixelBasicExpressionParser.ValfuncContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PixelBasicExpressionParser.isnanfunc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIsnanfunc([NotNull] PixelBasicExpressionParser.IsnanfuncContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PixelBasicExpressionParser.isnanfunc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIsnanfunc([NotNull] PixelBasicExpressionParser.IsnanfuncContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace PixelBasic