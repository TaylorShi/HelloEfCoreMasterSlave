## 业务背景

某车企开展引荐活动送积分，需要提供一个服务对引荐信息进行管理，通过API接口提供引荐信息的管理能力。

![](/Assets/MySql-Master-Slave-EfCore.svg)

*简单架构示意图*

## 涉及组件

- `MediatR`
- `EntityFrameworkCore`
- `Swashbuckle`
- `MySqlConnector`
- `Newtonsoft.Json`

## 解决方案和分层

```bash
dotnet new sln -o HelloEfCoreMasterSlave
```

这里我们将采用面向**领域驱动设计**(`DDD`)的模式，先将解决方案中项目完成分组：

- `0.Shared` 共享项目，定义业务无关的基础代码和接口定义
- `1.Infrastructure` 基础层，定义仓储、Context
- `2.Domain` 领域层，定义领域模式和领域事件
- `3.Application` 应用层，定义命令和处理程序，协调调度任务
- `4.Interface` 接口层，定义API终结点、验证
- `5.Test` 应用测试，定义API终结点、验证

## 相关文章

* [乘风破浪，遇见最佳跨平台跨终端框架.Net Core/.Net生态 - MYSQL主从实例+Entity Framework Core实现读写分离之实战演练](https://www.cnblogs.com/taylorshi/p/16848812.html)