using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Redis;

namespace RedisDemo
{
    //
    class Program
    {
        static void Main(string[] args)
        {
            using (IRedisClient client = new RedisClient("127.0.0.1",6379))
            {
                //删除当前数据库所有的KEY
                //  client.FlushDb();
                //添加字段
                client.Set<int>("ID", 1);
                client.Set<string>("name", "张三");
                client.Set<int>("Depid", 666946);
                //var shuchu = client.Get<string>("name");
                Console.WriteLine("OK");
                Console.ReadKey();
            }
        }
    }
}
