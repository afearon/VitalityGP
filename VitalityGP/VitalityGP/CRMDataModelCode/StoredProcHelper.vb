'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel
Namespace CRM
    Public Module SprocHelper
        Public Function Execws_VitalityGP_GPAdd(ByVal session As Session, ByVal PracticeID As Integer, ByVal GPCode As String, ByVal GPName As String, ByVal Telephone As String, ByVal EmailAddress As String) As DevExpress.Xpo.DB.SelectedData
            Return session.ExecuteSproc("ws_VitalityGP_GPAdd", New OperandValue(PracticeID), New OperandValue(GPCode), New OperandValue(GPName), New OperandValue(Telephone), New OperandValue(EmailAddress))
        End Function
        Public Function Execws_VitalityGP_GPAddIntoObjects(ByVal session As Session, ByVal PracticeID As Integer, ByVal GPCode As String, ByVal GPName As String, ByVal Telephone As String, ByVal EmailAddress As String) As System.Collections.Generic.ICollection(Of ws_VitalityGP_GPAddResult)
            Return session.GetObjectsFromSproc(Of ws_VitalityGP_GPAddResult)("ws_VitalityGP_GPAdd", New OperandValue(PracticeID), New OperandValue(GPCode), New OperandValue(GPName), New OperandValue(Telephone), New OperandValue(EmailAddress))
        End Function
        Public Function Execws_VitalityGP_GPAddIntoDataView(ByVal session As Session, ByVal PracticeID As Integer, ByVal GPCode As String, ByVal GPName As String, ByVal Telephone As String, ByVal EmailAddress As String) As XPDataView
            Dim sprocData As DevExpress.Xpo.DB.SelectedData = session.ExecuteSproc("ws_VitalityGP_GPAdd", New OperandValue(PracticeID), New OperandValue(GPCode), New OperandValue(GPName), New OperandValue(Telephone), New OperandValue(EmailAddress))
            Return New XPDataView(session.Dictionary, session.GetClassInfo(GetType(ws_VitalityGP_GPAddResult)), sprocData)
        End Function
        Public Sub Execws_VitalityGP_GPAddIntoDataView(ByVal dataView As XPDataView, ByVal session As Session, ByVal PracticeID As Integer, ByVal GPCode As String, ByVal GPName As String, ByVal Telephone As String, ByVal EmailAddress As String)
            Dim sprocData As DevExpress.Xpo.DB.SelectedData = session.ExecuteSproc("ws_VitalityGP_GPAdd", New OperandValue(PracticeID), New OperandValue(GPCode), New OperandValue(GPName), New OperandValue(Telephone), New OperandValue(EmailAddress))
            dataView.PopulateProperties(session.GetClassInfo(GetType(ws_VitalityGP_GPAddResult)))
            dataView.LoadData(sprocData)
        End Sub
    End Module
End Namespace