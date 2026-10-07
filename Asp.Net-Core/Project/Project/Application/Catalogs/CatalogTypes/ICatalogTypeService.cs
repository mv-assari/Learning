using Application.Dtos;
using Application.Interfaces.Contexts;
using AutoMapper;
using Common;
using Domain.Catalogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Catalogs.CatalogTypes
{
    public interface ICatalogTypeService
    {
        BaseDto<CatalogTypeDto> Add(CatalogTypeDto catalogType);
        BaseDto Remove(int id);
        BaseDto<CatalogTypeDto> Edit(CatalogTypeDto catalogType);
        BaseDto<CatalogTypeDto> FindById(int id);
        PaginatedItemsDto<CatalogTypeListDto> GetList(int? parentId, int page, int pageSize);
    }

    public class CatalogTypeService : ICatalogTypeService
    {
        private readonly IDataBaseContext context;
        private readonly IMapper mapper;

        public CatalogTypeService(IDataBaseContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public BaseDto<CatalogTypeDto> Add(CatalogTypeDto catalogType)
        {
            var model = mapper.Map<CatalogType>(catalogType);
            context.CatalogTypes.Add(model);
            context.SaveChanges();
            return new BaseDto<CatalogTypeDto>
                       (mapper.Map<CatalogTypeDto>(model),
                        new List<string> { $"تایپ {model.Type} با موفقیت در سیستم ثبت شد"},
                        true);
        }

        public BaseDto<CatalogTypeDto> Edit(CatalogTypeDto catalogType)
        {
            var model=context.CatalogTypes.SingleOrDefault(p=>p.Id== catalogType.Id);
            mapper.Map(catalogType,model);
            context.SaveChanges();
            return new BaseDto<CatalogTypeDto>
                       (mapper.Map<CatalogTypeDto>(model),
                        new List<string> { $"تایپ {model.Type} با موفقیت ویرایش شد" },
                        true);

        }

        public BaseDto<CatalogTypeDto> FindById(int id)
        {
            var data = context.CatalogTypes.Find(id);
            var result = mapper.Map<CatalogTypeDto>(data);

            return new BaseDto<CatalogTypeDto>(result, null, true);
        }

        public PaginatedItemsDto<CatalogTypeListDto> GetList(int? parentId, int page, int pageSize)
        {
            int totalCount = 0;
            var model = context.CatalogTypes.Where(p=>p.ParentCatalogTypeId==parentId)
                                            .PagedResult(page,pageSize,out totalCount);

            var result=mapper.ProjectTo<CatalogTypeListDto>(model).ToList();

            return new PaginatedItemsDto<CatalogTypeListDto>(page,pageSize,totalCount,result);
        }

        public BaseDto Remove(int id)
        {
            var catalogType = context.CatalogTypes.Find(id);
            context.CatalogTypes.Remove(catalogType);
            context.SaveChanges();
            return new BaseDto(new List<string> { "آیتم با موفقیت حذف شد" }, true);
        }
    }

    public class CatalogTypeDto
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int? ParentCatalogTypeId { get; set; }
    }

    public class CatalogTypeListDto
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int SubTypeCount { get; set; }
    }
}
