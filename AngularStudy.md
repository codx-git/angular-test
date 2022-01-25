# ANGULARSTUDY
第一，模块<br>
- 不同于Node.js或ES6中的模块的模块，NG的模块就是一个抽象的容器，用于对组件进行分组
  整个应用初始时只有一个主模块：AppModule
  
第二，组件<br>
- 是一段可以反复使用的页面片段，如页头、轮播、手风琴
- 组件(Component)=模板(Template)+脚本(Script)+样式(Style)
  
第三，数据绑定<br>
- HTML绑定：{{ NG表达式 }}
- 属性绑定
- 指令绑定
- 事件绑定
- 双向数据绑定
<br>

## 创建一个自定义组件
1. 创建组件Class ，自定义一个文件如`book.component.ts`
    ```
    //装饰器声明这是一个组件
    @Component({
       selector:'app-book', //被调用时名称
       template:'<h2>我的组件</h2>'  
       //页面设计内容如：<h2>我的组件</h2>
       //templateUrl:'./book.component.html' 将组件内容写在html文件中
       //styleUrls:['./XX.css','./XXXXX.css'] 可以引入多个样式css文件
    })

    //导出组件
    export class bookComponent{}
    ```
2. 在某个模块中注册组件class，模块文件如：`book.module.ts`中
    ```
    @Ngmodule({
        declarations:'bookComponent', //export class bookComponent
    })
    //声明这个组件
    ```
3. 使用已经注册过的组件，如：在`book.component.html`中使用`<app-book>...XX..</app-book>`<br>
    使用之后页面会出现标题二：我的组件
<br>

4. $\color{red}{Angular CLI 提供快速创建组件的工具}$ <br>
   `ng generate component 组件名` or <br>
   `ng g component 组件名`

## 数据绑定
### 一、简单的绑定
1. 在`book.component.ts`中
    ```
       export class bookComponent{
           uname = Zhang;
           age = 22;
       }
   ```
2. 在`book.component.html`中引用数据
    ```
       <div>{{uname}}</div>
       <div>{{age}}</div>
       //运行结果，界面内容：Zhang，22
   ```
 3. $\color{red}{HTML绑定}$<br> 
   算术运算：`{{age+2}}`<br>
   比较运算、逻辑运算: `{{age>18}}`<br>
   三目运算：`{{age>=18 ? '成年':'未成年'}}`<br>
   调用函数运算：`{{uname.length}} 、{{uname.toUpperCase()}}`<br>
    * 不支持创建对象、JSON序列化
 4. $\color{red}{属性绑定}$<br> 
   形式1：直接在属性上用{{}} `<p title="{{uname}}">这是一个属性</p>`<br>
   形式2：直接使用[]做属性绑定`<p [title]="uname">这是一个属性</p>`<br>
    `<p [title]=" '当前年龄：' + age" `变量和常量结合时要用英文''和+才行，将常量变成字符串<br>
5.  $\color{red}{事件绑定}$<br> 
    ```
    //在html文件中添加button按钮实现事件
       <button (click)="printUname()">输出用户名</button>
    //在component.ts文件class中添加事件函数
        export class bookComponent{
            //class内部成员属性
            uname = 'Zhang';
            age = 22;

            //class内部成员方法,不需要返回类型
            printUname(){
                console.log(this.uname)
            }
        }
    ```
### 二、Angular中的指令系统
1. 循环绑定：*ngForof<br>
   `<ANY *ngFor="let 临时变量 of 数据>`
    ```
    //1.在.module.ts文件中添加一个数据组如
       empList = ["xx","yy","zz"];
    //2.在.html文件中添加引用
    //方法一：
       <ul>
           <li *ngFor="let e of empList">{{e}}</li>
       </ul>
    //方法二：
       <ul>
           <li *ngFor="let e of empList;let i=index">{{i}}-{{e}}</li>
       </ul>
    //方法三:
       <ul>
           <li *ngFor="let e of empList;index as i">{{i}}-{{e}}</li>
       </ul>
    ```
 2. 选择绑定：*ngIf<br>
   `<ANY *ngIf="布尔表达式">`<br>
   or`<ANY *ngIf="condition;then thenBlock else elseBlock">`
    ```
      isPayingUser=false;

      //简单的选择
      <div *ngIf="isPayingUser">
          此区域内容仅付费用户可见
      </div>

      //带有then和else的选择
      <div *ngIf="isPayingUser; then theBlock else elseBlock"></div>
      <ng-template #thenBlock>已付款成功,成为会员！！！</ng-template>
      <ng-template #elseBlock>请先成为会员！！！</ng-template>
    ```
3. 样式绑定：[ngStyle]<br>
   <b>说明ngStyle绑定的值必须是一个对象，对象属性就是CSS样式</b><br>
   `<ANY [ngStyle]="StyleName">`
    ```
    //在.html文件中添加引用
    <button [ngStyle]="myStyleObj">加载更多内容</button>

    //在.module.ts文件中添加样式对象
    myStyleObj={
        backgroundColor:'green',
        color:'#fff',
        borderColor:'#252'
    }
    ```
4. 样式绑定：[ngClass]<br>
   <b>说明：ngClass绑定的值必须是一个对象，对象属性就是CSS Class名，属性值为true/false，true时class出现，否则class不出现</b>
   `<ANY [ngStyle]="CSSClassName">`
   