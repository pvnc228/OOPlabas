using System;
public class Program{
    static void Main(string[] args){
// Создание корневого узла
        Node rootNode = new Node("Корневой узел");

// Добавление потомков
        rootNode.AddChild(new Node("Узел 1"));
        rootNode.AddChild(new Node("Узел 2"));

// Добавление потомков для "Узел 1"
        rootNode.GetChild(0).AddChild(new Node("Узел 1.1"));
        rootNode.GetChild(0).AddChild(new Node("Узел 1.2"));

// Добавление потомков для "Узел 2"
        rootNode.GetChild(1).AddChild(new Node("Узел 2.1"));

// Печать дерева
        rootNode.PrintTree();

    }
}