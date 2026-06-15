using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Long_Method
{
    public class LibraryManager_After
    {
        private readonly List<Book> _books;
        private readonly List<Member> _members;
        private readonly List<Loan> _loans;

        public LibraryManager_After()
        {
            _books = new List<Book>();
            _members = new List<Member>();
            _loans = new List<Loan>();
        }

        private Member FindMember(int memberId)
        {
            // پیدا کردن عضو
            foreach (var m in _members)
            {
                if (m.Id == memberId)
                {
                    return m;
                }
            }

            return null;
        }
        private Book FindBook(string isbn)
        {
            // پیدا کردن کتاب
            foreach (var b in _books)
            {
                if (b.ISBN == isbn)
                {
                    return b;
                }
            }

            return null;
        }
        private int CountActiveLoans(int memberId)
        {
            // بررسی محدودیت امانت
            int activeLoans = 0;
            foreach (var loan in _loans)
            {
                if (loan.MemberId == memberId && !loan.IsReturned)
                {
                    activeLoans++;
                }
            }

            return activeLoans;
        }
        private decimal CalculateUnpaidFines(int memberId)
        {
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

            return totalFines;
        }
        private Loan CreateLoan(int memberId,string isbn)
        {
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
            
            return newLoan;
        }
        private void UpdateBookStatus(string isbn,bool isAvailable)
        {
            // بروزرسانی وضعیت کتاب
            foreach (var b in _books)
            {
                if (b.ISBN == isbn)
                {
                    b.IsAvailable = isAvailable;
                    break;
                }
            }
        }
        private void SendNotification(string phone, string title, DateTime dueDate)
        {
            // ارسال پیامک (شبیه‌سازی)
            Console.WriteLine($"ارسال پیامک به {phone}: کتاب '{title}' تا تاریخ {dueDate:yyyy/MM/dd} به شما امانت داده شد.");
        }
        private void LogBorrow(string title, string name)
        {
            // ثبت لاگ
            Console.WriteLine($"LOG: {DateTime.Now} - امانت کتاب '{title}' به عضو '{name}'");
        }
        private string ValidateMember(Member member)
        {
            if (member == null)
            {
                return "خطا: عضو یافت نشد!";
            }

            if (!member.IsActive)
            {
                return "خطا: حساب کاربری شما غیرفعال است!";
            }

            return null;
        }
        private string ValidateBook(Book book)
        {
            if (book == null)
            {
                return "خطا: کتاب یافت نشد!";
            }

            if (!book.IsAvailable)
            {
                return "خطا: کتاب در حال حاضر امانت داده شده است!";
            }
            return null;
        }
        private string ValidateActiveLoans(int activeLoans)
        {
            if (activeLoans >= 5)
            {
                return "خطا: شما نمی‌توانید بیشتر از ۵ کتاب امانت بگیرید!";
            }
            return null;
        }
        private string ValidateTotalFines(decimal totalFines)
        {
            if (totalFines > 0)
            {
                return $"خطا: شما {totalFines} تومان جریمه دیرکرد دارید. لطفاً ابتدا جرایم را پرداخت کنید!";
            }

            return null;
        }

        public string BorrowBook(int memberId, string isbn)
        {
            var member=FindMember(memberId);
            var error= ValidateMember(member);
            if (error != null) return error;

            
            var book=FindBook(isbn);
            error= ValidateBook(book);
            if (error != null) return error;

            var activeLoans= CountActiveLoans(memberId);
            error=ValidateActiveLoans(activeLoans);
            if (error != null) return error;

            var totalFines= CalculateUnpaidFines(memberId);
            error = ValidateTotalFines(totalFines);
            if (error != null) return error;

            var newLoan= CreateLoan(memberId,isbn);

            UpdateBookStatus(isbn,isAvailable:false);

            SendNotification(member.Phone, book.Title, newLoan.DueDate);

            LogBorrow(book.Title, member.Name);
            

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
