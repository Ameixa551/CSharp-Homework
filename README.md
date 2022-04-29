# CSharp-Homework

软件构造基础作业

## Homework01-0218

1. 简易控制台计算器
2. 简易windows窗口计算器<br/>

## Homework02-0225
1. 编写程序输出用户指定数据的所有素数因子。
2. 编程求一个整数数组的最大值、最小值、平均值和所有数组元素的和。
3. 用“埃氏筛法”求2~ 100以内的素数。2~ 100以内的数，先去掉2的倍数，再去掉3的倍数，再去掉4的倍数，以此类推...最后剩下的就是素数。
4. 如果矩阵上每一条由左上到右下的对角线上的元素都相同，那么这个矩阵是托普利茨矩阵 。给定一个 M x N 的矩阵，当且仅当它是托普利茨矩阵时返回 True。<br/>

## Homework03-0304
1. 编写面向对象程序实现长方形、正方形、三角形等形状的类。每个形状类都能计算面积、判断形状是否合法。 请尝试合理使用接口/抽象类、属性来实现。
2. 随机创建10个形状对象，计算这些对象的面积之和。 尝试使用简单工厂设计模式来创建对象。<br/>

## Homework04-0311
1. 为示例中的泛型链表类添加类似于List<T>类的ForEach(Action<T> action)方法。通过调用这个方法打印链表元素，求最大值、最小值和求和（使用lambda表达式实现）。<br/>
2. 使用事件机制，模拟实现一个闹钟功能。闹钟可以有嘀嗒（Tick）事件和响铃（Alarm）两个事件。在闹钟走时时或者响铃时，在控制台显示提示信息。<br/>

## Homework05-0318
写一个订单管理的控制台程序，能够实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户、订单金额等进行查询）功能。<br/>
提示：主要的类有Order（订单）、OrderDetails（订单明细），OrderService（订单服务），订单数据可以保存在OrderService中一个List中。在Program里面可以调用OrderService的方法完成各种订单操作。<br/>
要求：<br/>
（1）使用LINQ语言实现各种查询功能，查询结果按照订单总金额排序返回。<br/>
（2）在订单删除、修改失败时，能够产生异常并显示给客户错误信息。<br/>
（3）作业的订单和订单明细类需要重写Equals方法，确保添加的订单不重复，每个订单的订单明细不重复。<br/>
（4）订单、订单明细、客户、货物等类添加ToString方法，用来显示订单信息。<br/>
（5） OrderService提供排序方法对保存的订单进行排序。默认按照订单号排序，也可以使用Lambda表达式进行自定义排序。<br/>

  ## Homework06-0325
1.  在上次作业的OrderService中添加一个Export方法，可以将所有的订单序列化为XML文件；添加一个Import方法可以从XML文件中载入订单。<br/>
2.  对订单程序中OrderService的各个Public方法添加测试用例。<br/>

  ## Homwork07-0401
 将课本中例5-31的Cayley树绘图代码进行修改。添加一组控件用以调节树的绘制参数。参数包括递归深度（n）、主干长度（leng）、右分支长度比（per1）、左分支长度比（per2）、右分支角度（th1）、左分支角度（th2）、画笔颜色（pen）<br/>
  
  ##  Homework08-0408
  为订单管理的程序添加一个WinForm的界面。通过这个界面，调用OrderService的各个方法，实现创建订单、删除订单、修改订单、查询订单、导出订单、导入订单等功能。<br/>
要求：<br/>
（1）WinForm的界面部分单独写一个项目，依赖于原来的项目。<br/>
（2）可以使用两个窗口。主窗口实现查询展示功能，以及放置各种功能按钮。新建/修改订单功能使用弹出窗口。<br/>
（3）注意窗口的布局，在窗口尺寸变化时，不出现错位挤压等情况。<br/>
（4）尽量通过数据绑定来实现功能。订单和订单明细各使用一个bindingsource，通过DataMember来实现主从对象绑定。<br/>

  ##  Homework09-0415
  改进书上例子：<br/>
  （1）只爬取指定网站的网页<br/>
  （2）只有爬取html等网页时才解析爬取下一页<br/>
  （3）相对地址转成完整地址爬取<br/>
  （4）尝试使用winform配置初始URL，显示已经爬取的URL信息和错误的URL信息<br/>
  
  ##  Homework10-0422
  (在Homework09-0415中)将上次作业的爬虫程序，使用并行处理进行优化，实现更快速的网页爬取。<br/>
  
  ##  Homework11-0429
  修改之前做的订单程序，基于EF框架，将订单保存到MySql数据库中，并实现订单的增删改查功能。<br/>

