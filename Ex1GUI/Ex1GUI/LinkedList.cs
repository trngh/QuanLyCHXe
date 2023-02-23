using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1GUI
{
    public class LinkedList
    {
        Node Head;
        Node Tail;
        public LinkedList()
        {
            Head = Tail = null;
        }

        // Kiem tra danh sach
        public bool IsEmpty()
        {
            if (Head == null)
                return true;
            return false;
        }

        // So phan tu trong danh sach
        public int Length()
        {
            int length = 0;
            for (Node p = Head; p != null; p = p.Next)
                ++length;
            return length;

        }

        // Truy cap vi tri phan tu
        public Node Get(int index)
        {
            int count = 0;
            for (Node p = Head; p != null; p = p.Next)
            {
                if (index == count)
                    return p;
                else ++count;
            }
            return null;
        }

        // Phan co gia tri lon nhat trong danh sach
        public Node Max()
        {
            LinkedList tempList = new LinkedList();
            tempList.Head = Head;
            tempList.Tail = Tail;
            tempList.QuickSort("gia xe");
            return tempList.Get(Length() - 1);
        }

       
        // Khoi tao NODE
        public Node CreataNode(Automobile xe)
        {
            Node newNode = new Node(xe);
            if (newNode == null)
                Console.WriteLine("Khong du bo nho!");
            return newNode;
        }

        // Them phan tu vao sau danh sach
        public void AddFirst(Automobile xe)
        {
            Node Node = new Node(xe);
            if (IsEmpty())
                Head = Tail = Node;
            else
            {
                Head.Prev = Node;
                Node.Next = Head;
                Head = Node;
            }
        }

        // Them phan tu vao cuoi danh sach
        public void AddLast(Automobile xe)
        {
            Node Node = new Node(xe);
            if (IsEmpty())
                Head = Tail = Node;
            else
            {
                Node.Prev = Tail;
                Tail.Next = Node;
                Tail = Node;
            }
        }

        // Them phan tu vao sau phan tu q
        public void AddNode(Node q, Node p)
        {
            if (q == Tail)
                AddLast(p.Xe);
            else
            {
                p.Next = q.Next;
                q.Next.Prev = p;
                q.Next = p;
                p.Prev = q;
            }
        }

        // Xoa phan tu dau danh sach
        public void RemoveFirst()
        {
            if (IsEmpty())
                Console.WriteLine("Danh sach rong!\n");
            else
            {
                if (Head == Tail)
                    Head = Tail = null;
                else
                {
                    Node Node = Head;
                    Head = Head.Next;
                    Head.Prev = null;
                }
            }
        }

        // Xoa phan tu cuoi danh sach
        public void RemoveLast()
        {
            if (IsEmpty())
                Console.WriteLine("Danh sach rong!\n");
            else
            {
                if (Head == Tail)
                    Head = Tail = null;
                else
                {
                    Node Node = Tail;
                    Tail.Prev.Next = null;
                    Tail = Tail.Prev;
                }
            }
        }

        // Xoa phan tu q trong danh sach 
        public void RemoveNode(Node p)
        {
            if (p == Head)
                RemoveFirst();
            else
            {
                if (p == Tail)
                    RemoveLast();
                else
                {
                    Node q = p.Prev;
                    p.Next.Prev = q;
                    q.Next = p.Next;
                }
            }
        }

        // Xoa toan bo danh sach
        public void RemoveAll()
        {
            Head = Tail = null;
        }

        // Tim kiem phan tu trong danh sach
        public Node SearchNode(Automobile xe)
        {
            for (Node p = Head; p != null; p = p.Next)
            {
                if (p.Xe.maXe.Equals(xe.maXe))
                    return p;
            }
            return null;
        }

        // Kiem tra ton tai phan tu trong danh sach
        public bool Contains(Automobile xe)
        {
            for (Node p = Head; p != null; p = p.Next)
            {
                string maXe = p.Xe.maXe;
                string tenXe = p.Xe.tenXe;
                string dongXe = p.Xe.dongXe;
                string phienBan = p.Xe.phienBan;
                if (maXe.Equals(xe.maXe) || 
                    tenXe.Equals(xe.tenXe) && dongXe.Equals(xe.dongXe) && phienBan.Equals(xe.phienBan))
                    return true;
            }
            return false;
        }


        // Copy danh sach
        public void CopyTo(LinkedList myList)
        {
            for (Node p = myList.Head; p != null; p = p.Next)
                AddLast(p.Xe);
        }

        // Tim kiem theo tieu chi
        public LinkedList SearchNodes(string danhMuc, string tieuChi)
        {
            LinkedList newList1 = new LinkedList();
            LinkedList newList2 = new LinkedList();
            LinkedList newList3 = new LinkedList();
            LinkedList newList4 = new LinkedList();
            LinkedList newList5 = new LinkedList();

            switch (danhMuc)
            {
                case "ma xe":
                    for (Node p = Head; p != null; p = p.Next)
                    {
                        if (tieuChi.Equals(p.Xe.maXe.ToLower()))
                            newList1.AddLast(p.Xe);
                    }
                    break;
                case "ten xe":
                    for (Node p = Head; p != null; p = p.Next)
                    {
                        if (tieuChi.Equals(p.Xe.tenXe.ToLower()))
                            newList2.AddLast(p.Xe);
                    }
                    break;
                case "dong xe":
                    for (Node p = Head; p != null; p = p.Next)
                    {
                        if (tieuChi.Equals(p.Xe.dongXe.ToLower()))
                            newList3.AddLast(p.Xe);
                    }
                    break;
                case "phien ban":
                    for (Node p = Head; p != null; p = p.Next)
                    {
                        if (tieuChi.Equals(p.Xe.phienBan.ToLower()))
                            newList4.AddLast(p.Xe);
                    }
                    break;
                case "gia ban":
                    {
                        Double.TryParse(tieuChi, out Double giaBan);
                        for (Node p = Head; p != null; p = p.Next)
                        {
                            if (giaBan == p.Xe.giaBan)
                                newList5.AddLast(p.Xe);
                        }
                    }
                    break;
                default:
                    break;
            }

            return danhMuc.Equals("ma xe") ? newList1 : danhMuc.Equals("ten xe") ? newList2 : danhMuc.Equals("dong xe") ? newList3 : danhMuc.Equals("phien ban") ? newList4 : newList5;
        }

        public void ChangeInfo(Node p, Automobile xe)
        {
            p.Xe.tenXe = xe.tenXe;      
            p.Xe.dongXe = xe.dongXe;      
            p.Xe.phienBan = xe.phienBan;      
            p.Xe.giaBan = xe.giaBan;      
        }

        // Xoa danh sach theo chi tieu
        public void RemoveNodes(LinkedList myList)
        {
            for (Node q = myList.Head; q != null; q = q.Next)
            {
                for (Node p = Head; p != null; p = p.Next)
                {
                    if (q.Xe.maXe == p.Xe.maXe)
                        if (p == Head)
                            RemoveFirst();
                        else
                            RemoveNode(p.Prev);
                }
            }
        }

        // Sap xep danh sach theo thuat toan SelectionSort
        public LinkedList SelectionSort()
        {
            LinkedList tempList = new LinkedList();
            while (Head != null)
            {
                Node minNode = Head;
                for (Node p = Head.Next; p != null; p = p.Next)
                {
                    if (p.Xe.giaBan < minNode.Xe.giaBan)
                        minNode = p;
                }
                tempList.AddLast(minNode.Xe);
                if (minNode == Head)
                    RemoveFirst();
                else
                    RemoveNode(minNode.Prev);
            }
            return tempList;
        }

        // Sap xep danh sach theo thuat toan QuickSort
        public void QuickSort(string tieuChi)
        {
            LinkedList tempList1 = new LinkedList();
            LinkedList tempList2 = new LinkedList();

            if (Head == Tail)
                return;

            for (Node p = Head.Next; p != null; p = p.Next)
            {
                switch (tieuChi)
                {
                    case "ma xe":
                        if (string.Compare(p.Xe.maXe, Head.Xe.maXe) == -1)
                            tempList1.AddLast(p.Xe);
                        else
                            tempList2.AddLast(p.Xe);
                        break;
                    case "ten xe":
                        if (string.Compare(p.Xe.tenXe, Head.Xe.tenXe) == -1)
                            tempList1.AddLast(p.Xe);
                        else
                            tempList2.AddLast(p.Xe);
                        break;
                    case "gia xe":
                        if (p.Xe.giaBan < Head.Xe.giaBan)
                            tempList1.AddLast(p.Xe);
                        else
                            tempList2.AddLast(p.Xe);
                        break;
                    default:
                        break;
                }
                
                //if (p.Xe.giaBan < Head.Xe.giaBan)
                //    tempList1.AddLast(p.Xe);
                //else
                //    tempList2.AddLast(p.Xe);
            }
            tempList1.AddLast(Head.Xe);

            tempList1.QuickSort(tieuChi);
            tempList2.QuickSort(tieuChi);

            if (tempList2.Head != null)
            {
                tempList2.Head.Prev = tempList1.Tail;
                tempList1.Tail.Next = tempList2.Head;
            }

            Head = tempList1.Head;
            if (tempList2.IsEmpty())
                Tail = tempList1.Tail;
            else
                Tail = tempList2.Tail;
        }

        // Them them danh sach moi vao danh sach ban dau 
        public void MergeTwoLists(LinkedList myList)
        {
            if (!myList.IsEmpty())
            {
                if (IsEmpty())
                {
                    Head = myList.Head;
                    Tail = myList.Tail;
                }
                else
                {
                    myList.Tail.Prev = Tail;
                    Tail.Next = myList.Head;
                    Tail = myList.Tail;
                }
            }

        }

        // Xuat danh sach
        public void Show()
        {
            for (Node p = Head; p != null; p = p.Next)
            {
                Console.WriteLine(p.Xe.ToString());
            }
        }

        public void SortDescending(string tieuChi)
        {
            LinkedList list = new LinkedList();
            QuickSort(tieuChi);
            for (Node p = Tail; p != null; p = p.Prev)
                list.AddLast(p.Xe);
            Head = list.Head;
            Tail = list.Tail;
        }
        // Chuyen doi danh sach qua chuoi
        public override string ToString()
        {
            string str = "";
            for (Node p = Head; p != null; p = p.Next)
            {
                str += p.Xe.ToString();
            }
            return str;
        }
    }
}
