using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;

// ��騥 ᢥ����� �� �⮩ ᡮથ �।��⠢������ ᫥���騬 ����஬
// ����� ��ਡ�⮢. ������� ���祭�� ��� ��ਡ�⮢, �⮡� �������� ᢥ�����,
// �易��� � ᡮમ�.
[assembly: AssemblyTitle("SLCalculator")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("SLCalculator")]
[assembly: AssemblyCopyright("Copyright c  2022")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// ��⠭���� ���祭�� False ��� ��ࠬ��� ComVisible ������ ⨯� � �⮩ ᡮથ �������묨
// ��� ��������⮢ COM. �᫨ ����室��� �������� � ⨯� � �⮩ ᡮથ �१
// �� ������ COM, ��⠭���� ��ਡ�� ComVisible ��� �⮣� ⨯� � ���祭�� true.
[assembly: ComVisible(false)]

//�⮡� ����� ᮧ����� �������㥬�� �ਫ������, ������
//<UICulture>CultureYouAreCodingWith</UICulture> � 䠩�� .csproj
//� <PropertyGroup>. ���ਬ��, �� �ᯮ�짮����� ������᪮�� (���)
//� ᢮�� ��室��� 䠩��� ��⠭���� <UICulture> � en-US.  ��⥬ �⬥��� �८�ࠧ������ � �������਩
//��ਡ�� NeutralResourceLanguage ����.  ������� "en-US" �
//��ப� ����� ��� ���ᯥ祭�� ᮮ⢥��⢨� ����ன�� UICulture � 䠩�� �஥��.

//[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)]


[assembly: ThemeInfo(
    ResourceDictionaryLocation.None, //��� �ᯮ������ ᫮��� ����ᮢ �� ������� ⥬�⨪��
                                     //(�ᯮ������, �᫨ ����� �� ������ �� ��࠭��,
                                     // ��� � ᫮����� ����ᮢ �ਫ������)
    ResourceDictionaryLocation.SourceAssembly //��� �ᯮ����� ᫮���� 㭨���ᠫ��� ����ᮢ
                                              //(�ᯮ������, �᫨ ����� �� ������ �� ��࠭��,
                                              // � �ਫ������ ��� � �����-���� ᫮����� ����ᮢ ��� �����⭮� ⥬�)
)]


// �������� � ���ᨨ ��� ᡮન ������� ���� ᫥����� ���祭��:
//
//      �᭮���� ����� ���ᨨ
//      �������⥫�� ����� ���ᨨ
//      ����� ᡮન
//      ����� ।��樨
//
// ����� ������ �� ���祭�� ��� �ਭ��� ����� ᡮન � ।��樨 �� 㬮�砭�� 
// �ᯮ���� "*", ��� �������� ����:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]