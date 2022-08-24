using ola_mundo;
using System.IO;
using System;
using Xunit;
using FluentAssertions;

namespace ola_mundo.Test;

public class OlaMundoTest
{
    [Theory(DisplayName = "Deve exibir Olá, Mundo!")]
    [InlineData("Olá, Mundo!")]
    public void TestOlaMundo(string Expected)
    {        
        using (var NewOutput = new StringWriter())
        
        {
            Console.SetOut(NewOutput);
        
            Program.Main();
        
            string result = NewOutput.ToString().Trim();
    
            result.Should().Be(Expected);      
        }                    
    }
}