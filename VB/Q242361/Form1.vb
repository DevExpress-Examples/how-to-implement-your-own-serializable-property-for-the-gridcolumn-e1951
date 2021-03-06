﻿Imports DevExpress.XtraEditors
Imports System
Imports System.ComponentModel

Namespace Q242361
    Partial Public Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            Dim list = New BindingList(Of Item)()
            For i As Integer = 0 To 4
                list.Add(New Item() With { _
                    .ID = i, _
                    .Name = "Name" & i, _
                    .Description = "Description" & i _
                })
            Next i
            myGridControl1.DataSource = list
        End Sub

        Private Const LayoutPath As String = "..\..\layout.xml"
        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
            myGridView1.SaveLayoutToXml(LayoutPath)
        End Sub

        Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton2.Click
            myGridView1.RestoreLayoutFromXml(LayoutPath)
        End Sub
    End Class
    Public Class Item
        Public Property ID() As Integer
        Public Property Name() As String
        Public Property Description() As String
    End Class
End Namespace