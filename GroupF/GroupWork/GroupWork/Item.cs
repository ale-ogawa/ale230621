using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupWork
{
	internal class Item
	{
		//食材id
		public int ItemId { get; set; }
		//食材名
		public string ItemName { get; set; }
		//食材の賞味期限
		public DateTime ItemDate { get; set; }
		//食材名と賞味期限
		public string ItemInfo
		{
			get { return $"{ItemName} (賞味期限: {ItemDate:yyyy/MM/dd})"; }
		}

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="Item_name">食材名</param>
		/// <param name="ItemDate">食材の賞味期限</param>
		public Item(string itemName, DateTime itemDate)
		{
			this.ItemName = itemName;
			this.ItemDate = itemDate;
		}

		public Item(int itemId, string itemName)
		{
			this.ItemId = itemId;
			this.ItemName = itemName;
		}
		public Item(int itemId, string itemName, DateTime itemDate)
		{
			this.ItemId = itemId;
			this.ItemName = itemName;
			this.ItemDate = itemDate;
		}
		public Item()
		{
		}
	}
}
