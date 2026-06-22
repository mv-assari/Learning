using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Long_Method
{
    public class LibraryManager_Before
    {
        private readonly List<Book> _books;
        private readonly List<Member> _members;
        private readonly List<Loan> _loans;

        public LibraryManager_Before()
        {
            _books = new List<Book>();
            _members = new List<Member>();
            _loans = new List<Loan>();
        }

        public string BorrowBook(int memberId, string isbn)
        {
            // پیدا کردن عضو
            Member member = null;
            foreach (var m in _members)
            {
                if (m.Id == memberId)
                {
                    member = m;
                    break;
                }
            }

            if (member == null)
            {
                return "خطا: عضو یافت نشد!";
            }

            if (!member.IsActive)
            {
                return "خطا: حساب کاربری شما غیرفعال است!";
            }

            // پیدا کردن کتاب
            Book book = null;
            foreach (var b in _books)
            {
                if (b.ISBN == isbn)
                {
                    book = b;
                    break;
                }
            }

            if (book == null)
            {
                return "خطا: کتاب یافت نشد!";
            }

            if (!book.IsAvailable)
            {
                return "خطا: کتاب در حال حاضر امانت داده شده است!";
            }

            // بررسی محدودیت امانت
            int activeLoans = 0;
            foreach (var loan in _loans)
            {
                if (loan.MemberId == memberId && !loan.IsReturned)
                {
                    activeLoans++;
                }
            }

            if (activeLoans >= 5)
            {
                return "خطا: شما نمی‌توانید بیشتر از ۵ کتاب امانت بگیرید!";
            }

            // بررسی جریمه‌های دیرکرد
            decimal totalFines = 0;
            foreach (var loan in _loans)
            {
                if (loan.MemberId == memberId && loan.IsReturned && loan.ReturnDate > loan.DueDate)
                {
                    var delayDays = (loan.ReturnDate.Value - loan.DueDate).Days;
                    totalFines += delayDays * 1000; // هر روز ۱۰۰۰ تومان
                }
            }

            if (totalFines > 0)
            {
                return $"خطا: شما {totalFines} تومان جریمه دیرکرد دارید. لطفاً ابتدا جرایم را پرداخت کنید!";
            }

            // ثبت امانت
            var newLoan = new Loan
            {
                Id = Guid.NewGuid(),
                BookISBN = isbn,
                MemberId = memberId,
                LoanDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(14),
                IsReturned = false
            };

            _loans.Add(newLoan);

            // بروزرسانی وضعیت کتاب
            foreach (var b in _books)
            {
                if (b.ISBN == isbn)
                {
                    b.IsAvailable = false;
                    break;
                }
            }

            // ارسال پیامک (شبیه‌سازی)
            Console.WriteLine($"ارسال پیامک به {member.Phone}: کتاب '{book.Title}' تا تاریخ {newLoan.DueDate:yyyy/MM/dd} به شما امانت داده شد.");

            // ثبت لاگ
            Console.WriteLine($"LOG: {DateTime.Now} - امانت کتاب '{book.Title}' به عضو '{member.Name}'");

            return $"موفقیت: کتاب '{book.Title}' با موفقیت به {member.Name} امانت داده شد. تاریخ بازگشت: {newLoan.DueDate:yyyy/MM/dd}";
        }
    }

    // کلاس‌های کمکی
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public bool IsAvailable { get; set; } = true;
    }

    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; } = true;
    }

    public class Loan
    {
        public Guid Id { get; set; }
        public string BookISBN { get; set; }
        public int MemberId { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public bool IsReturned { get; set; }
    }
}
