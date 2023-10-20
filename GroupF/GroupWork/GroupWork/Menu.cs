using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupWork
{
	internal class Menu
	{
		//メニュー番号
		public int MenuId { get; set; }
		//メニュー名
		public string MenuName { get; set; }
		//カロリー
		public int MenuCalorie { get; set; }
		//調理時間
		public int MenuTime { get; set; }
		//食材
		public string MenuIngredient { get; set; }
		//レシピ
		public string MenuRecipe { get; set; }
		//イメージのパス
		public string MenuPicture { get; set; }

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="Menu_name"></param>
		public Menu(string menuName)
		{
			this.MenuName = menuName;
		}

		public Menu(int menuId, string menuName)
		{
			this.MenuId = menuId;
			this.MenuName = menuName;
		}

		/// <summary>
		/// 引数なしコンストラクタ
		/// </summary>
		public Menu()
		{

		}
	}
}
