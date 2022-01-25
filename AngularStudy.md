#ANGULARSTUDY#
第一，模块
第二，组件


##创建一个自定义组件##
1. 创建组件Class ，自定义一个文件如`book.component.ts`<br>
    ```
    @Component({
       selector:'app-book',
       template:'' //页面设计内容如<h2>我的组件</h2>
    })
    
    export class bookComponent{}
    ```
2. 在某个模块中注册组件class，模块文件如`book.module.ts`中
    ```
    @Ngmodule({
        declarations:'bookComponent',
    })
    ```
3. 使用已经注册过的组件，如`book.component.html`中使用`<app-book>...XX..</app-book>`<br>
    使用之后页面会出现标题二：我的组件
