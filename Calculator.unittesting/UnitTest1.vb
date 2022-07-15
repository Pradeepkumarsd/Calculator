Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports calculator_2

<TestClass()>
Public Class UnitTest1

    <TestMethod()>
    Public Sub Addition()
        'A Arrange , A - Act , A -Assert
        'Arrange - Addition - 1+2 = 3
        Dim str As String = "1+2"
        Dim Exp_Output As Decimal = 3
        Dim Actual_Output As Decimal

        'Act - We will be calling function which is need to tested 
        Dim Result = New Calculation
        Actual_Output = Result.WriteGetResult(str)

        'Assert - In this we are just checking whether the actual output and expected output is same or not.
        'If assert statement give's you false - that test case Wil fail.
        Assert.AreEqual(Exp_Output, Actual_Output)
    End Sub

    <TestMethod()>
    Public Sub Subtraction()
        'Arrange
        Dim str As String = "1-2"
        Dim Exp_Output As Decimal = -1
        Dim Actual_Output As Decimal

        'Act
        Dim Result = New Calculation
        Actual_Output = Result.WriteGetResult(str)

        'Assert
        Assert.AreEqual(Exp_Output, Actual_Output)
    End Sub

    <TestMethod()>
    Public Sub Multiplication()
        'Arrange
        Dim str As String = "2*3"
        Dim Exp_Output As Decimal = 6
        Dim Actual_Output As Decimal

        'Act
        Dim Result = New Calculation
        Actual_Output = Result.WriteGetResult(str)

        'Assert
        Assert.AreEqual(Exp_Output, Actual_Output)
    End Sub

    <TestMethod()>
    Public Sub MoreLogic()
        'Arrange
        Dim Str As String = "1+2*3"
        Dim Expected_Output As Decimal = 7
        Dim Actual_Output As Decimal

        'Act
        Dim Result = New Calculation
        Actual_Output = Result.WriteGetResult(Str)

        'Assert
        Assert.IsTrue(Expected_Output = Actual_Output)
    End Sub


End Class