using System;
using System.Collections.Generic;
using System.Text;

namespace _22._2
{
    class Stack
    {
        private class Node //вложенный класс, реализующий элемент стека
        {
            private object inf;
            private Node next;
            public Node(object nodeInfo)
            {
                inf = nodeInfo;
                next = null;
            }
            public Node Next
            {
                get { return next; }
                set { next = value; }
            }
            public object Inf
            {
                get { return inf; }
                set { inf = value; }
            }
        } //конец класса Node
        private Node head; //ссылка на вершину стека
        private int count;
        public Stack() //конструктор класса, создает пустой стек
        {
            head = null;
            count = 0;
        }
        public void Push(object nodeInfo) // добавляет элемент в вершину стека
        {
            Node r = new Node(nodeInfo);
            r.Next = head;
            head = r;
            ++count;
        }
        public object Pop() //извлекает элемент из вершины стека, если он не пуст
        {
            if (head == null)
            {
                throw new Exception("Стек пуст");
            }
            else
            {
                --count;
                Node r = head;
                head = r.Next;
                return r.Inf;
            }
        }
        public virtual int Count { get { return count; } }
        public bool IsEmpty //определяет пуст или нет стек
        {
            get
            {
                if (head == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
