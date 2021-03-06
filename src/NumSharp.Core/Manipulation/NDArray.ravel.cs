﻿using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace NumSharp.Core
{
    public partial class NDArray
    {
        public NDArray delete(IEnumerable delete)
        {
            var sysArr = this.Storage.GetData();

            NDArray res = null;

            switch( sysArr)
            {
                case double[] castedSysArr : 
                {
                    var castedDelete = delete as double[];

                    res = np.array(castedSysArr.Where(x => !castedDelete.Contains(x) ).ToArray());

                    break;
                }
                case float[] castedSysArr : 
                {
                    var castedDelete = delete as float[];

                    res = np.array(castedSysArr.Where(x => !castedDelete.Contains(x) ).ToArray());

                    break;
                }
                case int[] castedSysArr :
                {
                    var castedDelete = delete as int[];

                    res = np.array(castedSysArr.Where(x => !castedDelete.Contains(x) ).ToArray());

                    break;
                }
                default : 
                {
                    throw new IncorrectTypeException();
                }
            }
            
            return res;
        }
    }
}
