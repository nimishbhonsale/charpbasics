using System;
using CSharpBasics.Delegates.Models;

namespace CSharpBasics.Delegates
{
	public enum DelegateExample {
		Basic,
		AnonymousMethodAndLambda,
		Lambda,
		BuiltInFunc,
		BuiltInAction,
		BuiltInPredicate,
		ExpressionTree
	};

	public class DelegateExamples
	{
		public void Execute(DelegateExample type){

			switch (type) {

			case DelegateExample.Basic:
				new Calculator ().Execute ();
				break;

			case DelegateExample.AnonymousMethodAndLambda:
				new AnonymousMethodAndLambda ().Execute ();
				break;

			case DelegateExample.BuiltInFunc:
				new BuiltInDelegates ().Execute (BuiltInDelegateOption.FuncBasic);
				//new BuiltInDelegates ().Execute (BuiltInDelegateOption.FuncParameterized);
				break;

			case DelegateExample.BuiltInAction:
				new BuiltInDelegates ().Execute (BuiltInDelegateOption.Action);
				break;

			case DelegateExample.BuiltInPredicate:
				new BuiltInDelegates ().Execute (BuiltInDelegateOption.Predicate);
				break;

			case DelegateExample.ExpressionTree:
				break;

			}
		}
	}
}

