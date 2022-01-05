namespace QuanLyBanHang.Models
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity.Spatial;
	using System.Linq;
	[Table("Receipt")]
	public partial class Receipt
	{
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public Receipt()
		{
			ReceiptDetails = new HashSet<ReceiptDetail>();
		}

		public long Id { get; set; }

		[Column(TypeName = "date")]
		public DateTime RecDate { get; set; }

		[StringLength(200)]
		public string Notes { get; set; }

		public long ProvId { get; set; }

		public virtual Provider Provider { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<ReceiptDetail> ReceiptDetails { get; set; }
		public int RecSum { get => ReceiptDetails.Sum(rd => rd.Amount * rd.Price); }
	}
}
