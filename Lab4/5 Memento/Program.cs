using _5_Memento;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var document = new TextDocument("Initial content. ");
        var editor = new TextEditor(document);

        editor.Print();

        editor.Write("First change. ");
        editor.Print();

        editor.Write("Second change. ");
        editor.Print();

        editor.Undo();
        editor.Print();

        editor.Undo();
        editor.Print();

        editor.Undo();
        editor.Print();

        editor.PrintChangeLog();
    }
}