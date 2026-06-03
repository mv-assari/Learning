using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Threading.Tasks;

namespace CustomModelBinder.Models
{
    //1|vahid|mva@gmail.com
    public class UserCustomModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if(bindingContext==null)
                throw new ArgumentNullException(nameof(bindingContext));

            var values = bindingContext.ValueProvider.GetValue("user");

            if (values.Length==0)
            {
                return Task.CompletedTask;
            }

            var splitData = values.FirstValue.Split('|');
            if (splitData.Length >= 0)
            {
                User user = new User
                {
                    Id = int.Parse(splitData[0]),
                    Name = splitData[1],
                    Email = splitData[2]
                };

                bindingContext.Result = ModelBindingResult.Success(user);
            }

            return Task.CompletedTask;
        }
    }
}
