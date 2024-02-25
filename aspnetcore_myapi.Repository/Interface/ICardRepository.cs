using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetcore_myapi.Repository.Dtos.Condition;
using aspnetcore_myapi.Repository.Dtos.DataModel;

namespace aspnetcore_myapi.Repository.Interface
{
    public interface ICardRepository
    {
        /// <summary>
        /// 查詢卡片列表
        /// </summary>
        /// <returns></returns>
        IEnumerable<CardDataModel> GetList(CardSearchCondition info);

        /// <summary>
        /// 查詢卡片
        /// </summary>
        /// <param name="id">卡片編號</param>
        /// <returns></returns>   
        CardDataModel Get(int id);

        /// <summary>
        /// 新增卡片
        /// </summary>
        /// <param name="parameter">卡片參數</param>
        /// <returns></returns>
        bool Insert(CardCondition info);

        /// <summary>
        /// 更新卡片
        /// </summary>
        /// <param name="id">卡片編號</param>
        /// <param name="parameter">卡片參數</param>
        /// <returns></returns>
        bool Update(int id, CardCondition info);

        /// <summary>
        /// 刪除卡片
        /// </summary>
        /// <param name="id">卡片編號</param>
        /// <returns></returns>
        bool Delete(int id);
    }
}