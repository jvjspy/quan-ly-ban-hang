using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyBanHang.Models
{
	public partial class DBContext : DbContext
	{
		public DBContext()
				: base("name=DBContext")
		{
		}

		public virtual DbSet<Admin> Admins { get; set; }
		public virtual DbSet<Category> Categories { get; set; }
		public virtual DbSet<Invoice> Invoices { get; set; }
		public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }
		public virtual DbSet<Product> Products { get; set; }
		public virtual DbSet<Provider> Providers { get; set; }
		public virtual DbSet<Receipt> Receipts { get; set; }
		public virtual DbSet<ReceiptDetail> ReceiptDetails { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Admin>()
					.Property(e => e.Username)
					.IsUnicode(false);

			modelBuilder.Entity<Admin>()
					.Property(e => e.Password)
					.IsUnicode(false);

			modelBuilder.Entity<Category>()
					.HasMany(e => e.Products)
					.WithOptional(e => e.Category)
					.HasForeignKey(e => e.CatId);

			modelBuilder.Entity<Invoice>()
					.HasMany(e => e.InvoiceDetails)
					.WithRequired(e => e.Invoice)
					.HasForeignKey(e => e.InvId)
					.WillCascadeOnDelete(false);

			modelBuilder.Entity<Product>()
					.HasMany(e => e.InvoiceDetails)
					.WithRequired(e => e.Product)
					.HasForeignKey(e => e.ProdId)
					.WillCascadeOnDelete(false);

			modelBuilder.Entity<Product>()
					.HasMany(e => e.ReceiptDetails)
					.WithRequired(e => e.Product)
					.HasForeignKey(e => e.ProdId)
					.WillCascadeOnDelete(false);

			modelBuilder.Entity<Provider>()
					.Property(e => e.PhoneNumber)
					.IsUnicode(false);

			modelBuilder.Entity<Provider>()
					.Property(e => e.Email)
					.IsUnicode(false);

			modelBuilder.Entity<Provider>()
					.HasMany(e => e.Receipts)
					.WithRequired(e => e.Provider)
					.HasForeignKey(e => e.ProvId)
					.WillCascadeOnDelete(false);

			modelBuilder.Entity<Receipt>()
					.HasMany(e => e.ReceiptDetails)
					.WithRequired(e => e.Receipt)
					.HasForeignKey(e => e.RecId)
					.WillCascadeOnDelete(false);
		}
	}
}
