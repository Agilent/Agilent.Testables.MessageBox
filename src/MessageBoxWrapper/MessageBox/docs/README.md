# Agilent.Ace.Testables.MessageBox

This package contains an abstraction of the static `System.Windows.MessageBox` class found in .NET Framework 4.8 and .NET 8.0. It allows for an `IMessageBox` interface to be used instead and for mocks to be created.

## Usage

1. Pass `IMessageBox` as a dependency _via_ the constructor into the class you want to show a `MessageBox` from:
```csharp
public class TestableClass
{
    private readonly IMessageBox _messageBox;

    public TestableClass(IMessageBox messageBox)
    {
        _messageBox = messageBox;
    }

    public void DoWork()
    {
        _messageBox.Show("Hello World");
    }
}
```
2. In your IOC Container register `IMessageBox` and `Agilent.Ace.Testables.MessageBox`:
```csharp
_services.AddTransient<IMessageBox, MessageBox>();
```
3. In your tests, verify that the correct message is shown:
```csharp
[TestMethod]
public void Should_ShowMessageBox_When_DoWorkPerformed()
{
    // Arrange
    var mockMessageBox = new Mock<IMessageBox>();
    var sut = new TestableClass(mockMessageBox.Object);

    // Act
    sut.DoWork();

    // Assert
    mockMessageBox.Verify(x => x.Show(It.IsAny<string>()), Times.Once);
}
```
