using System;

namespace Replace_Type_Code_with_StateStrategy
{
    public class After
    {
        public void TestMethod()
        {
            var doc = new Document();

            Console.WriteLine(doc.GetStateName()); // پیش‌نویس
            Console.WriteLine(doc.CanEdit());      // True

            doc.Next();
            Console.WriteLine(doc.GetStateName()); // در بازبینی
            Console.WriteLine(doc.CanEdit());      // True

            doc.Next();
            Console.WriteLine(doc.GetStateName()); // منتشر شده
            Console.WriteLine(doc.CanEdit());      // False

            doc.Next(); // ❌ Exception: منتشر شده تغییر نمی‌کنه
        }
    }

    public class Document
    {
        private IDocumentState _status = new DraftState();

        public string GetStateName()
        {
            return _status.GetStateName();
        }

        public bool CanEdit()
        {
            return _status.CanEdit();
        }

        public void Next()
        {
            _status=_status.Next();
        }
        
    }

    public interface IDocumentState
    {
        string GetStateName();
        IDocumentState Next();
        bool CanEdit();
    }

    public class DraftState : IDocumentState
    {
        public bool CanEdit()
        {
            return true;
        }

        public string GetStateName()
        {
            return "پیش‌نویس";
        }

        public IDocumentState Next()
        {
            return new ReviewState();
        }
    }

    public class ReviewState : IDocumentState
    {
        public bool CanEdit()
        {
            return true;
        }

        public string GetStateName()
        {
            return "در بازبینی";
        }

        public IDocumentState Next()
        {
            return new PublishedState();
        }
    }

    public class PublishedState : IDocumentState
    {
        public bool CanEdit()
        {
            return false;
        }

        public string GetStateName()
        {
            return "منتشر شده";
        }

        public IDocumentState Next()
        {
            throw new Exception("منتشر شده تغییر نمی‌کنه");
        }
    }
}
