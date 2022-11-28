﻿namespace Interpreter.Context;

public class RomanXExpression : RomanExpression
{
    public override void Interpret(RomanContext value)
    {
        while ((value.Input - 90) >= 0)
        {
            value.Output += "XC";
            value.Input -= 90;
        }
        
        while ((value.Input - 50) >= 0)
        {
            value.Output += "L";
            value.Input -= 50;
        }
        
        while ((value.Input - 40) >= 0)
        {
            value.Output += "XL";
            value.Input -= 40;
        }
        while ((value.Input - 10) >= 0)
        {
            value.Output += "X";
            value.Input -= 10;
        }
    }
}