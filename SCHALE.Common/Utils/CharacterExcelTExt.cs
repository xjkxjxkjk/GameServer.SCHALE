using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCHALE.Common.FlatData;

namespace SCHALE.Common.Utils
{
    public enum StudentType
    {
        Normal,
        Unique,
        Event,
    }

    public static class CharacterExcelTExt
    {
        public static StudentType GetStudentType(this CharacterExcelT ch)
        {
            if (!ch.CollectionVisibleEndDate.StartsWith("2099"))
            {
                return StudentType.Unique;
            }
            else if (ch.CombineRecipeId == 0)
            {
                return StudentType.Event;
            }

            return StudentType.Normal;
        }
    }
}
