using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace RangeDataSource {
    public static class DataSourceHelper {
        public static bool IsFieldExists(object dataSource, string fieldName, Type reqType) {
            PropertyDescriptorCollection pdc = ((ITypedList)dataSource).GetItemProperties(null);
            foreach (PropertyDescriptor pd in pdc) {
                if (pd.DisplayName == fieldName) {
                    if (reqType == null || pd.PropertyType == reqType) return true;
                }
            }
            return false;
        }
    }
}
