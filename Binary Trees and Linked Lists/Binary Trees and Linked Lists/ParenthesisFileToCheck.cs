using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Trees_and_Linked_Lists
{
    public  class ParenthesisFileToCheck
    {
        string textFile = "[EnableQuery]\r\n [HttpGet]\r\n public IQueryable<ClinicDTO> GetAllClinicDTO()\r\n {\r\n     DateTime start = DateTime.Now;\r\n     DateTime end;\r\n     var currentUser = User as ClaimsPrincipal;\r\n     CurrentAccount account;\r\n     try\r\n     {\r\n         account = new CurrentAccount(_context, currentUser);\r\n     }\r\n     catch (Exception ex)\r\n     {\r\n         _logger.LogError(new LogMessage(Request,$\"ClinicController: \" + ex).ToJson());\r\n         return ConvertClinics(new List<Clinic>()).AsQueryable();\r\n     }\r\n     DateTimeOffset requestedDate = Utils.GetUpdatedAtFromRequest(Request);\r\n     List<Clinic> clinics = (from\r\n                                  clinic in _context.Clinics\r\n                             where\r\n                                 clinic.Id == account.ClinicId &&\r\n                                 clinic.IsDeleted == false &&\r\n                                 clinic.UpdatedAt >= requestedDate\r\n                             orderby\r\n                                 clinic.UpdatedAt\r\n                             select\r\n                                 clinic\r\n                              ).ToList();\r\n     end = DateTime.Now;\r\n     double retrieveTime = (end - start).TotalMilliseconds;\r\n      _logger.LogInformation(new LogMessage(Request,$\"ClinicController: User \" + account.Username + \" retrieved \" + clinics.Count + \" in \" + retrieveTime + \" ms\").ToJson());\r\n\r\n     try\r\n     {\r\n         return ConvertClinics(clinics).AsQueryable();\r\n     }\r\n     finally\r\n     {\r\n         end = DateTime.Now;\r\n          _logger.LogInformation(new LogMessage(Request,$\"ClinicController: User \" + account.Username + \" converted all in \" + (end - start).TotalMilliseconds + \" ms\").ToJson());\r\n\r\n         if ((end - start).TotalMilliseconds > _context.MaxProcessTime)\r\n         {\r\n              _logger.LogWarning(new LogMessage(Request,$\"ClinicController: User \" + account.Username + \" retrieved \" + clinics.Count + \" in \" + retrieveTime + \" ms\" +\r\n                                                          \", converted all in \" + (end - start).TotalMilliseconds + \" ms\" +\r\n                                                          \", request \" + Utils.GetUri(Request)).ToJson());\r\n         }\r\n     }\r\n }"
    }
}
