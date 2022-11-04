using System;
using System.Collections.Generic;
using System.Text;

namespace Tesla.Console.AccessibilityLevels
{
    /// <summary>
    /// 线程不安全
    /// </summary>
    internal class Singleton
    {
        private static Singleton _instance = null;

        /// <summary>
        /// Prevents a default instance of the 
        /// <see cref="Singleton"/> class from being created.
        /// </summary>
        private Singleton()
        {
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        public static Singleton Instance
        {
            get { return _instance ?? (_instance = new Singleton()); }
        }
    }

    /// <summary>
    /// 线程安全
    /// </summary>
    internal class Singleton2
    {
        private static Singleton2 _instance = null;
        private static readonly object SynObject = new object();

        /// <summary>
        /// Prevents a default instance of the 
        /// <see cref="Singleton"/> class from being created.
        /// </summary>
        private Singleton2()
        {
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        public static Singleton2 Instance
        {
            get
            {
                lock (SynObject)
                {
                    return _instance ?? (_instance = new Singleton2());
                }
            }
        }
    }

    /// <summary>
    /// 由于这种静态初始化的方式是在自己的字段被引用时才会实例化
    /// </summary>
    internal class Singleton3
    {
        private static readonly Singleton3 _instance = new Singleton3();

        /// <summary>
        /// 定义静态的构造函数，当静态字段被引用时才进行初始化
        /// </summary>
        static Singleton3()
        {

        }

        private Singleton3()
        {

        }

        public static Singleton3 Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
