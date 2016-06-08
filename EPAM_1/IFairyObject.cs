using System;

namespace EPAM_1
{
    /// <summary>
    /// Must be implemenyed by all fairy objects (e.x. teremok or any animal)
    /// </summary>
    interface IFairyObject
    {
        /// <summary>
        ///  Stands for fairy tail object name
        /// </summary>
        /// 
        /// <result>
        /// Returns short name of current class
        /// </result>
        string Name { get; }
    }
}
