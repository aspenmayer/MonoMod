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
		internal unsafe readonly partial struct PSTR
			: IEquatable<PSTR>
		{
			internal readonly byte* Value;
			internal PSTR(byte* value) => this.Value = value;
			public static implicit operator byte*(PSTR value) => value.Value;
			public static implicit operator PSTR(byte* value) => new PSTR(value);
			public static bool operator ==(PSTR left, PSTR right) => left.Value == right.Value;
			public static bool operator !=(PSTR left, PSTR right) => !(left == right);

			public bool Equals(PSTR other) => this.Value == other.Value;

			public override bool Equals(object obj) => obj is PSTR other && this.Equals(other);

			public override int GetHashCode() => unchecked((int)this.Value);
		}
	}
}
