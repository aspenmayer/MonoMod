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
	namespace System.SystemInformation
	{
		/// <summary>Contains information about the current computer system. This includes the architecture and type of the processor, the number of processors in the system, the page size, and other such information.</summary>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//sysinfoapi/ns-sysinfoapi-system_info">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.63-beta+89e7e0c43f")]
		internal partial struct SYSTEM_INFO
		{
			internal winmdroot.System.SystemInformation.SYSTEM_INFO._Anonymous_e__Union Anonymous;
			/// <summary>
			/// <para>The page size and the granularity of page protection and commitment. This is the page size used by the <a href="https://docs.microsoft.com/windows/desktop/api/memoryapi/nf-memoryapi-virtualalloc">VirtualAlloc</a> function.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//sysinfoapi/ns-sysinfoapi-system_info#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal uint dwPageSize;
			/// <summary>A pointer to the lowest memory address accessible to applications and dynamic-link libraries (DLLs).</summary>
			internal unsafe void* lpMinimumApplicationAddress;
			/// <summary>A pointer to the highest memory address accessible to applications and DLLs.</summary>
			internal unsafe void* lpMaximumApplicationAddress;
			/// <summary>A mask representing the set of processors configured into the system. Bit 0 is processor 0; bit 31 is processor 31.</summary>
			internal nuint dwActiveProcessorMask;
			/// <summary>
			/// <para>The number of logical processors in the current group. To retrieve this value, use the <a href="https://docs.microsoft.com/windows/desktop/api/sysinfoapi/nf-sysinfoapi-getlogicalprocessorinformation">GetLogicalProcessorInformation</a> function. <div class="alert"><b>Note</b>  For information about the  physical processors shared by logical processors, call <a href="https://docs.microsoft.com/windows/desktop/api/sysinfoapi/nf-sysinfoapi-getlogicalprocessorinformationex">GetLogicalProcessorInformationEx</a> with the <i>RelationshipType</i> parameter set to RelationProcessorPackage (3).</div> <div> </div></para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//sysinfoapi/ns-sysinfoapi-system_info#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal uint dwNumberOfProcessors;
			/// <summary>An obsolete member that is retained for compatibility. Use the <b>wProcessorArchitecture</b>, <b>wProcessorLevel</b>, and <b>wProcessorRevision</b> members to determine the type of processor.</summary>
			internal uint dwProcessorType;
			/// <summary>The granularity for the starting address at which virtual memory can be allocated. For more information, see <a href="https://docs.microsoft.com/windows/desktop/api/memoryapi/nf-memoryapi-virtualalloc">VirtualAlloc</a>.</summary>
			internal uint dwAllocationGranularity;
			/// <summary>
			/// <para>The architecture-dependent processor level. It should be used only for display purposes. To determine the feature set of a processor, use the <a href="https://docs.microsoft.com/windows/desktop/api/processthreadsapi/nf-processthreadsapi-isprocessorfeaturepresent">IsProcessorFeaturePresent</a> function. If <b>wProcessorArchitecture</b> is PROCESSOR_ARCHITECTURE_INTEL, <b>wProcessorLevel</b> is defined by the CPU vendor. If <b>wProcessorArchitecture</b> is PROCESSOR_ARCHITECTURE_IA64, <b>wProcessorLevel</b> is set to 1.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//sysinfoapi/ns-sysinfoapi-system_info#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal ushort wProcessorLevel;
			/// <summary>
			/// <para>The architecture-dependent processor revision. The following table shows how the revision value is assembled for each type of processor architecture.</para>
			/// <para></para>
			/// <para>This doc was truncated.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//sysinfoapi/ns-sysinfoapi-system_info#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal ushort wProcessorRevision;

			[StructLayout(LayoutKind.Explicit)]
			[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.63-beta+89e7e0c43f")]
			internal partial struct _Anonymous_e__Union
			{
				[FieldOffset(0)]
				internal uint dwOemId;
				[FieldOffset(0)]
				internal winmdroot.System.SystemInformation.SYSTEM_INFO._Anonymous_e__Union._Anonymous_e__Struct Anonymous;

				[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.63-beta+89e7e0c43f")]
				internal partial struct _Anonymous_e__Struct
				{
					internal winmdroot.System.Diagnostics.Debug.PROCESSOR_ARCHITECTURE wProcessorArchitecture;
					internal ushort wReserved;
				}
			}
		}
	}
}
