using LibraryAmoCRM.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRMTests.Data
{
    public static class NoteArray
    {
        internal static IEnumerable<NoteDTO> GetNoteDTOs()
        {
            return new List<NoteDTO> {
                new NoteDTO{
                    id = 121217677,
                    responsible_user_id = 2079682,
                    created_by = 2864566,
                    created_at = 1553761419,
                    updated_at = 1553761299,
                    account_id = 17769199,
                    group_id = 151543,
                    is_editable = false,
                    element_id = 13525003,
                    element_type = 2,
                    attachment = "c09m_Rekvizity_Albatros_sport.pdf",
                    note_type = 5,
                    @params = new NoteParamsDTO
                    {
                        text = "Реквизиты Альбатрос спорт.pdf",
                        html =  @"<a href=" + new Uri("https://apfitness.amocrm.ru/download/c09m_Rekvizity_Albatros_sport.pdf").ToString() + ">Реквизиты Альбатрос спорт.pdf</a>"
                    }
                },
                new NoteDTO{
                    id = 42491409,
                    responsible_user_id = 2079718,
                    created_by = 2079718,
                    created_at = 1519999319,
                    updated_at = 1519999340,
                    account_id = 17769199,
                    group_id = 212704,
                    is_editable = true,
                    element_id = 15547627,
                    element_type = 1,
                    attachment = "",
                    note_type = 4,
                    text = "продление договора"
                }
            };
        }
    }
}
