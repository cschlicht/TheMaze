Public Class Form7

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        MoveToStart()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub MoveToStart()
        Dim StartingPoint = Panel1.Location()
        StartingPoint.Offset(116, 107)
        Cursor.Position = PointToScreen(StartingPoint)


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Wall_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter, Panel1.MouseEnter, Label9.MouseEnter, Label2.MouseEnter, Label1.MouseEnter, Label5.MouseEnter, Label4.MouseEnter
        MoveToStart()

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form10.Show()

    End Sub
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) _
                                               Handles Panel1.MouseDown
        Panel1.Capture = False
    End Sub

End Class