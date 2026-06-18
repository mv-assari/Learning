using System;

namespace Replace_Type_Code_with_StateStrategy
{
    public class Before
    {
    }

    public class Document
    {
        public const int DRAFT = 0;
        public const int REVIEW = 1;
        public const int PUBLISHED = 2;

        public int State { get; set; } = DRAFT;

        public string GetStateName()
        {
            switch (State)
            {
                case DRAFT: return "پیش‌نویس";
                case REVIEW: return "در بازبینی";
                case PUBLISHED: return "منتشر شده";
                default: throw new Exception("نامعتبر");
            }
        }

        public void Next()
        {
            switch (State)
            {
                case DRAFT: State = REVIEW; break;
                case REVIEW: State = PUBLISHED; break;
                case PUBLISHED: throw new Exception("منتشر شده تغییر نمی‌کنه");
            }
        }

        public bool CanEdit()
        {
            switch (State)
            {
                case DRAFT: return true;
                case REVIEW: return true;
                case PUBLISHED: return false;
                default: throw new Exception("نامعتبر");
            }
        }
    }
}
