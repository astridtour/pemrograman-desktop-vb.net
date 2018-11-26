Public Class Form1
    Dim length As Double
    Dim breadth As Double
    Dim heigth As Double

    Sub setbreath(ByVal bre As Double)
        breadth = bre
    End Sub
    Sub setheight(ByVal hei As Double)
        Height = hei
    End Sub
    Function getVolume() As Double
        Return length * breadth * Height
    End Function

    'Private Sub BtnHasil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHasil.Click
    '    Sub Main()
    '    Dim Box1 As Box = New Box()        ' Declare Box1 of type Box
    '    Dim Box2 As Box = New Box()        ' Declare Box2 of type Box
    '    Dim volume As Double = 0.0     ' Store the volume of a box here
    '    ' box 1 specification 
    '    Box1.setLength(6.0)
    '    Box1.setBreadth(7.0)
    '    Box1.setHeight(5.0)

    '    'box 2 specification
    '    Box2.setLength(12.0)
    '    Box2.setBreadth(13.0)
    '    Box2.setHeight(10.0)

    '    ' volume of box 1
    '    volume = Box1.getVolume()
    '    Console.WriteLine("Volume of Box1 : {0}", volume)

    '    'volume of box 2
    '    volume = Box2.getVolume()
    '    Console.WriteLine("Volume of Box2 : {0}", volume)
    '    Console.ReadKey()
    'End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        TxtBreadth.Clear()
        TxtHasil.Clear()
        TxtHeight.Clear()
        TxtLength.Clear()
        TxtLength.Focus()

    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        MsgBox("SERIUSNYA KAMU TUTUP INI PROGRAM WE???")
        Me.Close()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtBreadth.Text = " "
        TxtHeight.Text = " "
        TxtLength.Text = " "
        TxtLength.Focus()

    End Sub

    Private Sub BtnHasil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHasil.Click
        Call Function
    End Sub
End Class
