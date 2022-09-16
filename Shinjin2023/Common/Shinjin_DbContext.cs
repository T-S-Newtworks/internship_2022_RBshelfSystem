using System.Data.Entity;

namespace Shinjin2023.Util
{
    class Shinjin_DbContext : DbContext
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Shinjin_DbContext()
            : base("name=Shinjin_DbContext")
        {
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    //スキーマを指定（デフォルトではdbo）
        //    modelBuilder.HasDefaultSchema("PRACTICE_DB_2023");
        //}

    }
}
