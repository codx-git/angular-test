# angular-test
this is a angular study


## 创建一个新的 abpframew-angular的web应用项目<br>
第一 ，   `abp new 'yourprojectname' -u angular`<br>
第二 ，   通过vs打开aspnet-core项目里的.sln文件<br>
第三 ,    DbMigrator设置为启动项，运行.host设置为启动项，运行<br>


创建module文件夹到aspnet-core文件中(应用模块，应用程序？？还不理解)<br>
`abp add-module module --new --add-to-solution-file`<br>
https://github.com/antosubash/NewModuleWithTieredAbpApp


## 更改为MySQL数据库<br>
第一 ， .entityframeworkcore.entityframeworkcore把其中所有与SQL sever更改为mysql，下载程序包：<br>
   `volo.abp.    entityframeworkcore.mysql`<br>
   卸载SQL serve版本的<br>
   https://blog.csdn.net/weixin_42254467/article/details/107443946<br>
第二 ，程序包管理控制器执行，默认项目选择`entityframeworkcore`<br>
   `add-migration '随便名字'`  遇到Build failed的时候重新生成项目<br>
   再执行` update-databaes '随便名字'`<br>
第三 ，更改appseting.json中的字符集<br>
第四 , Dbmigration设置为启动项，执行<br>
第五 ，HttpAPI.host设置为启动项,执行<br>


## 添加一个API ##
   https://docs.abp.io/zh-Hans/abp/latest/Tutorials/Todo/Index?UI=NG&DB=EF
