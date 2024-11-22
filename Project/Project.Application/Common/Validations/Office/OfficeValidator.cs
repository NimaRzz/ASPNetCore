using Project.Domain.Common.Dto;
using Project.Application.Services.Offices.Commands.AddOffice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Project.Application.Services.Offices.Commands.UpdateOffice;
using Project.Domain.Repository.Office;
using Project.Application.Common.Converter;

namespace Project.Application.Common.Validations.Office
{
    public class OfficeValidator
    {

        public static async Task<ResultDto> ValidateOfficeRequest(object request)
        {
            ResultDto result = new ResultDto()
            {
                IsSuccess = true
            };

            // بررسی اینکه آیا شماره دفتر وارد شده است یا نه
            if (request is RequestUpdateOfficeDto updateRequest)
            {
                result = await ValidateRequest(updateRequest.Id, updateRequest.Name, updateRequest.ProvinceId, updateRequest.Address, updateRequest.WorkStart, updateRequest.WorkEnd);
            }
            else if (request is RequestAddOfficeDto addRequest)
            {
                result = await ValidateRequest(addRequest.Id, addRequest.Name, addRequest.ProvinceId, addRequest.Address, addRequest.WorkStart, addRequest.WorkEnd);
            }

            return result;
        }

        private static async Task<ResultDto> ValidateRequest(string id, string name, long province, string address, string workStart, string workEnd)
        {
            // بررسی اینکه شماره دفتر وارد شده باشد
            if (string.IsNullOrEmpty(id))
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "شماره دفتر را وارد کنید"
                };
            }

            // بررسی نام دفتر
            if (string.IsNullOrEmpty(name))
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "نام دفتر را وارد کنید"
                };
            }

            string pattern = @"^[\u0600-\u06FF0-9]+$";
            if (!Regex.IsMatch(name, pattern))
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "فقط حروف فارسی و اعداد مجاز هستند."
                };
            }

            // بررسی استان
            if (province > 31 || province < 1)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "این استان وجود ندارد. از اعداد 1 تا 31 انتخاب کنید"
                };
            }

            // بررسی آدرس دفتر
            if (string.IsNullOrEmpty(address))
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "ادرس را وارد کنید"
                };
            }

             var workStartResult = await ConvertToTimeSpan.Converter(workStart);
            var workEndResult = await ConvertToTimeSpan.Converter(workEnd);
          
            if (!workStartResult.IsSuccess)
            {
                return workStartResult;
            }
           
            if (!workEndResult.IsSuccess)
            {
                return workEndResult;
            }

            if (workStartResult.Data >= workEndResult.Data)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "ساعت پایان کاری باید بعد از ساعت شروع کاری باشد"
                };
            }

            return new ResultDto()
            {
                IsSuccess = true
            }; // اگر هیچ خطایی نبود، null برگشت می‌دهیم.
        }
    }

}
