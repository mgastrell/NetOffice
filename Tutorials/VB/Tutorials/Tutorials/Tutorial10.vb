﻿Public Class Tutorial10
    Implements ITutorial

    Dim _hostApplication As IHost

#Region "ITutorial Member"

    Public Sub Run() Implements TutorialsBase.ITutorial.Run

        'this property allows you to disable any events from Office applications
        Dim enableEvents As Boolean = LateBindingApi.Core.Settings.EnableEvents


        ' this property is the common threadculture for accessing Office.
        ' default is en-us(1033)
        Dim threadCulture As System.Globalization.CultureInfo = LateBindingApi.Core.Settings.ThreadCulture


        ' this property allows you to enable NetOffice call Quit() for Application objects automaticly while Dispose()
        ' false by default
        Dim automaticQuit As Boolean = LateBindingApi.Core.Settings.EnableAutomaticQuit


        ' this property allows to enable a COM Message filter
        ' if you have a long time operation while office automation then the host application
        ' shows a MessageBox("Office Application is waiting for an OLE Task" 
        ' the enabled message filter suspress this dialog, as negativ side effect you cant use
        ' the SendKeys feature to signals an office application any user input
        Dim messageFilter As Boolean = LateBindingApi.Core.Settings.EnableMessageFilter


        ' the safemode is a feature that checks automaticly at runtime the methods oder properties you use are
        ' available in current office version. if it doesnt an EntityNotSupportedException was thrown
        ' false by default
        Dim safeMode As Boolean = LateBindingApi.Core.Settings.EnableSafeMode


        'get or set NetOffice logs essential system steps in the NetOffice DebugConsole
        Dim debugOutput As Boolean = LateBindingApi.Core.Settings.EnableDebugOutput


        Dim message As String = String.Format("Events enabled:{0}{6}Thread:{1}{6}AutomaticQuit enabled:{2}{6}MessageFilter enabled:{3}{6}SafeMode enabled:{4}{6}DebugOutput enabled:{5}{6}", enableEvents, threadCulture.LCID, automaticQuit, messageFilter, safeMode, debugOutput, Environment.NewLine)
        MessageBox.Show(message, "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Public ReadOnly Property Caption As String Implements TutorialsBase.ITutorial.Caption
        Get
            Return "Tutorial10"
        End Get
    End Property

    Public ReadOnly Property Description As String Implements TutorialsBase.ITutorial.Description
        Get
            Return IIf(_hostApplication.LCID = 1033, "NetOffice Settings", "Einstellungsmöglichkeiten für NetOffice")
        End Get
    End Property

    Public Sub Connect(ByVal hostApplication As TutorialsBase.IHost) Implements TutorialsBase.ITutorial.Connect

        _hostApplication = hostApplication

    End Sub

    Public Sub ChangeLanguage(ByVal lcid As Integer) Implements TutorialsBase.ITutorial.ChangeLanguage

    End Sub

    Public Sub Disconnect() Implements TutorialsBase.ITutorial.Disconnect

    End Sub

    Public ReadOnly Property Panel As System.Windows.Forms.UserControl Implements TutorialsBase.ITutorial.Panel
        Get
            Return Nothing
        End Get
    End Property


    Public ReadOnly Property Uri As String Implements TutorialsBase.ITutorial.Uri
        Get
            Return IIf(_hostApplication.LCID = 1033, "http://netoffice.codeplex.com/wikipage?title=Tutorial10_EN_VB", "http://netoffice.codeplex.com/wikipage?title=Tutorial10_DE_VB")
        End Get
    End Property

#End Region

End Class
