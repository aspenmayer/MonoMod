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
using global::System.Runtime.Versioning;
using winmdroot = global::Windows.Win32;
namespace Windows.Win32
{
	namespace Foundation
	{
		[DebuggerDisplay("{Value}")]
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.63-beta+89e7e0c43f")]
		internal readonly partial struct BOOL
			: IEquatable<BOOL>
		{
			internal readonly int Value;
			internal BOOL(int value) => this.Value = value;
			public static implicit operator int(BOOL value) => value.Value;
			public static explicit operator BOOL(int value) => new BOOL(value);
			public static bool operator ==(BOOL left, BOOL right) => left.Value == right.Value;
			public static bool operator !=(BOOL left, BOOL right) => !(left == right);

			public bool Equals(BOOL other) => this.Value == other.Value;

			public override bool Equals(object obj) => obj is BOOL other && this.Equals(other);

			public override int GetHashCode() => this.Value.GetHashCode();
			internal BOOL(bool value) => this.Value = value ? 1 : 0;
			public static implicit operator bool(BOOL value) => value.Value != 0;
			public static implicit operator BOOL(bool value) => new BOOL(value);
		}
	}
}
