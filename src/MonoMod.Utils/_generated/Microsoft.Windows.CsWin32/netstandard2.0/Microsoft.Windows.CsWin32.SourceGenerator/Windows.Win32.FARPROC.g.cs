﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#pragma warning disable CS1591,CS1573,CS0465,CS0649,CS8019,CS1570,CS1584,CS1658,CS0436,CS8981
using global::System;
using global::System.Diagnostics;
using global::System.Diagnostics.CodeAnalysis;
using global::System.Runtime.CompilerServices;
using global::System.Runtime.InteropServices;
using winmdroot = global::Windows.Win32;
namespace Windows.Win32
{
	namespace Foundation
	{
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.63-beta+89e7e0c43f")]
		internal partial struct FARPROC
		{
			internal IntPtr Value;
			internal FARPROC(IntPtr value) => this.Value = value;

			internal static FARPROC Null => default;

			internal bool IsNull => Value == default;
			public static implicit operator IntPtr(FARPROC value) => value.Value;
			public static explicit operator FARPROC(IntPtr value) => new FARPROC(value);
			public static bool operator ==(FARPROC left, FARPROC right) => left.Value == right.Value;
			public static bool operator !=(FARPROC left, FARPROC right) => !(left == right);

			public bool Equals(FARPROC other) => this.Value == other.Value;

			public override bool Equals(object obj) => obj is FARPROC other && this.Equals(other);

			public override int GetHashCode() => this.Value.GetHashCode();

			internal TDelegate CreateDelegate<TDelegate>()where TDelegate : Delegate => Marshal.GetDelegateForFunctionPointer<TDelegate>(this.Value);
		}
	}
}