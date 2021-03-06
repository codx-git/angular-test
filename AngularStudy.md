# ANGULARSTUDY
<strong>Angular核心概念</strong><br>
<i>第一，模块</i><br>
- 不同于Node.js或ES6中的模块的模块，NG的模块就是一个抽象的容器，用于对组件进行分组<br>
整个应用初始时只有一个主模块：AppModule
  
<i>第二，组件</i><br>
- 是一段可以反复使用的页面片段，如页头、轮播、手风琴
- 组件(Component)=模板(Template)+脚本(Script)+样式(Style)
  
<i>第三，数据绑定</i><br>
- HTML绑定：{{ NG表达式 }}
- 属性绑定
- 指令绑定
- 事件绑定
- 双向数据绑定

<i>第四，过滤器</i><br>
 - Filter：过滤器，用于在View中呈现数据时显示为另一种格式；过滤器的本质是一个函数，接收原始数据转换为新的格式进行：`function(oldVal){  ...  return newVal}`<br>
 - 使用过滤器：{{e.salay | 过滤器名(也称为管道)}}

# 目录
* 1. [创建一个自定义组件](#)
	* 1.1. [创建组件Class ，自定义一个文件如`book.component.ts`](#Classbook.component.ts)
	* 1.2. [在某个模块中注册组件class，模块文件如：`book.module.ts`中](#classbook.module.ts)
	* 1.3. [使用已经注册过的组件，如：在`book.component.html`中使用`<app-book>...XX..</app-book>`<br>](#book.component.htmlapp-book...XX..app-bookbr)
	* 1.4. [$\color{red}{Angular CLI 提供快速创建组件的工具}$ <br>](#colorredAngularCLIbr)
* 2. [数据绑定](#-1)
	* 2.1. [简单的绑定](#-1)
		* 2.1.1. [初始化内容](#-1)
		* 2.1.2. [$\color{red}{HTML绑定}$<br>](#colorredHTMLbr)
		* 2.1.3. [$\color{red}{属性绑定}$<br>](#colorredbr)
		* 2.1.4. [$\color{red}{事件绑定}$<br>](#colorredbr-1)
	* 2.2. [Angular中的指令系统](#Angular)
		* 2.2.1. [Angular中的指令分为三类:](#Angular:)
		* 2.2.2. [循环绑定：*ngForof<br>](#ngForofbr)
		* 2.2.3. [选择绑定：*ngIf<br>](#ngIfbr)
		* 2.2.4. [样式绑定：[ngStyle]<br>](#ngStylebr)
		* 2.2.5. [样式绑定：[ngClass]<br>](#ngClassbr)
		* 2.2.6. [了解：特殊选择绑定:[ngSwitch]<br>](#:ngSwitchbr)
		* 2.2.7. [$\color{red}{双向数据绑定指令：[(ngModule)]  — 重点}$ <br>](#colorredngModulebr)
		* 2.2.8. [扩展知识：如何自定义指令<br>](#br)
* 3. [自定义管道（过滤器）](#-1)
	* 3.1. [练习：<br>](#br-1)
		* 3.1.1. [实现添加、删除事件](#-1)
		* 3.1.2. [创建员工列表数组<br>](#br-1)
	* 3.2. [创建对象的两种方式<br>](#br-1)

# 内容
##  1. <a name=''></a>创建一个自定义组件
###  1.1. <a name='Classbook.component.ts'></a>创建组件Class ，自定义一个文件如`book.component.ts`
```typescript
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
###  1.2. <a name='classbook.module.ts'></a>在某个模块中注册组件class，模块文件如：`book.module.ts`中
```typescript
    @Ngmodule({
        declarations:'bookComponent', //export class bookComponent
    })
    //声明这个组件
```
###  1.3. <a name='book.component.htmlapp-book...XX..app-bookbr'></a>使用已经注册过的组件，如：在`book.component.html`中使用`<app-book>...XX..</app-book>`<br>
    使用之后页面会出现标题二：我的组件
<br>

###  1.4. <a name='colorredAngularCLIbr'></a>$\color{red}{Angular CLI 提供快速创建组件的工具}$ <br>
   `ng generate component 组件名` or <br>
   `ng g component 组件名`

##  2. <a name='-1'></a>数据绑定
###  2.1. <a name='-1'></a>简单的绑定
####  2.1.1. <a name='-1'></a>初始化内容
```typescript
        //在`book.component.ts`中
       export class bookComponent{
           uname = Zhang;
           age = 22;
       }
        //在`book.component.html`中引用数据
       <div>{{uname}}</div>
       <div>{{age}}</div>
       //运行结果，界面内容：Zhang，22
```
####  2.1.2. <a name='colorredHTMLbr'></a>$\color{red}{HTML绑定}$<br>
- 算术运算：`{{age+2}}`<br>
- 比较运算、逻辑运算: `{{age>18 && age<30}}`<br>
- 三目运算：`{{age>=18 ? '成年':'未成年'}}`<br>
- 调用函数运算：`{{uname.length}} 、{{uname.toUpperCase()}}`<br>
    * 不支持创建对象、JSON序列化
####  2.1.3. <a name='colorredbr'></a>$\color{red}{属性绑定}$<br>
- 形式1：直接在属性上用{{}} `<p title="{{uname}}">这是一个属性</p>`<br>
- 形式2：直接使用[]做属性绑定`<p [title]="uname">这是一个属性</p>`<br>
    `<p [title]=" '当前年龄：' + age" `变量和常量结合时要用英文''和+才行，将常量变成字符串<br>
####  2.1.4. <a name='colorredbr-1'></a>$\color{red}{事件绑定}$<br> 
```typescript
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
###  2.2. <a name='Angular'></a>Angular中的指令系统
####  2.2.1. <a name='Angular:'></a>Angular中的指令分为三类:
- 组件指令：NG中Component继承自Directive
- 结构型指令：会影响DOM树结构，必须使用 * 开头，如*ngFOr、*ngIf
- 属性型指令：不会影响DOM树结构，只会影响元素外观或行为，必须用 [] 括起来，如[ngClass]、[ngStyle]
####  2.2.2. <a name='ngForofbr'></a>循环绑定：*ngForof<br>
   `<ANY *ngFor="let 临时变量 of 数据></ANY>`
```typescript
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
####  2.2.3. <a name='ngIfbr'></a>选择绑定：*ngIf<br>
   `<ANY *ngIf="布尔表达式"></ANY>`<br>
   or`<ANY *ngIf="condition;then thenBlock else elseBlock"></ANY>`
```typescript
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
####  2.2.4. <a name='ngStylebr'></a>样式绑定：[ngStyle]<br>
<b>说明ngStyle绑定的值必须是一个对象，对象属性就是CSS样式</b><br>
`<ANY [ngStyle]="StyleName"></ANY>`

```typescript
    //在.html文件中添加引用
    <button [ngStyle]="myStyleObj" (click)="loadMore()">加载更多内容</button>

    //在.module.ts文件中添加样式对象
    myStyleObj={
        backgroundColor:'green',
        color:'#fff',
        borderColor:'#252'
    }
    loadMore(){ //点击后更改按钮颜色
        this.myStyleObj.backgroundColor="red"
        this.myStyleObj.color="black"
    }
```
####  2.2.5. <a name='ngClassbr'></a>样式绑定：[ngClass]<br>
   <b>说明：ngClass绑定的值必须是一个对象，对象属性就是CSS Class名，属性值为true/false，true时class出现，否则class不出现</b><br>
   `<ANY [ngStyle]="CSSClassName"></ANY>`

```typescript
   //在.html文件中添加引用
    <button [ngStyle]="myClassObj" (click)="loadMore2()">加载更多内容</button>

    //在.module.ts文件中添加样式对象
    myClassObj={
        btn: true,
        'btn-danger': false, //烤串法则
        'btn-success':ture  
    }
    loadMore2(){ //点击更改按钮颜色
        this.myClassObj["btn-danger"]=true
        this.myClassObj["btn-success"]=true
    }
```
####  2.2.6. <a name=':ngSwitchbr'></a>了解：特殊选择绑定:[ngSwitch]<br>
```typescript
    <ANY [ngSwitch]="表达式">
        <ANY *ngSwitchCase="值1"></ANY>
        <ANY *ngSwitchCase="值2"></ANY>
        ....
        <ANY *ngSwitchDefault></ANY>
    </ANY>
```
####  2.2.7. <a name='colorredngModulebr'></a>$\color{red}{双向数据绑定指令：[(ngModule)]  — 重点}$ <br>
方向1：Module => View，模型变则视图变<br>
方向2：View => Moudule，视图(表单元素)变则模型变<br>
`<input/select/textarea [(ngModel)]="uname">`<br>
    - 注意：ngModule指令不在CommonModule模块中，而在FormsModule中，使用之前必须在主模块中导入该模块;(ngModelChange)实时监听绑定内容是否改变
```typescript
    //app.module.ts导入FormsModule
    import { FormsModule } from '@angular/forms';

    @NgModule({
        ...others content...

        imports:[BrowserModule,
                FormsModule]
    })

    //.html引用
    <input [(ngModel)]="uname" placeholder="请输入用户名" (ngModelChange)="unameChange()">
    <p>当前用户名：{{uname}}</p>

    //.component.ts文件中添加函数
    unameChange(){//实时监听uname是否改变
        console.log(this.uname);
    }
```
####  2.2.8. <a name='br'></a>扩展知识：如何自定义指令<br>
创建指令的简单工具：`ng g directive 指令名`；自定义指令都是作为元素属性来使用的，selector应该是:[指令名]<br>
    `<ANY 指令名>...</ANY>`
```typescript
    //.Directive.ts文件中
    export class DirectDirective {
        //构造方法
        constructor(e:elementRef) {
           // console.log("ewr")
           e.nativeElement.style.color='#833'
           e.nativeElement.style.background='#123'
         }
    }
    
    //.html文件中引用
    <p appDirect>...</p>
```
##  3. <a name='-1'></a>自定义管道（过滤器）
- 创建管道class，实现转换功能
- 在模块中注册管道
- 在模板视图中使用管道
- 可以使用CLI命令行`ng g pipe 管道名`<br>
<div align="center" >
<img src=./image/Common_pipe.png width="350" height="350"/>
</div>

```typescript
    //1.创建一个sex.ts文件，文件内容如下：
    import { Pipe } from "@angular/core";
    @Pipe({
        name:'sex' //过滤器名\管道名
    })
    export class SexPipe{
        //管道到执行过滤任务的是一个固定的函数
        transform(val:Number,lang:string){
            if(lang=='zh'){ //可以设置其他内容如中英文显示
                if(val==1){
                    return '男'
                }else if(val=1){
                    return '女'
                }else{
                    return '未知'
                }
            } 
        }
    }

    //2.模块中注册
    //3.在.html文件中两种引用
    <p> {{e.sex | sex }} </p>
    <p [title]="empSex | sex"></p>
```
###  3.1. <a name='br-1'></a>练习：<br>
####  3.1.1. <a name='-1'></a>实现添加、删除事件
```typescript
    //在.component.ts文件中
    todolist=['Study','Work','Play']
    accidence=''

    doDelete(index: number){
        console.log(index)
        //删除指定数组下标元素
        this.todolist.splice(index,1)
    }
    addAccidence(){
        //console.log(this.accidence)
        this.todolist.push(this.accidence)
        this.accidence=''
    }

    //在HTML文件中
    <p *ngIf="todolist.length==0">This is no accidence</p> 
    <input [(ngModel)]="accidence" placeholder="please add a accidence">
    <button (click)="addAccidence()"> Add </button>
    <ul>
        <li *ngFor="let items of todolist;let i=index">
            {{i+1}}-{{items}}
            <button (click)="doDelete(i)">
                Delete
            </button>
        </li>
    </ul> 
```
####  3.1.2. <a name='br-1'></a>创建员工列表数组<br>
```typescript
    //在.component.ts文件添加内容和函数
    emplist=  [{eid:101,ename:"Zhang",sex:1,salay:5000},
                {eid:102,ename:"zheng",sex:0,salay:5100},
                {eid:103,ename:"Wang",sex:1,salay:5050}]

    doDelete(index: number){
        this.emplist.splice(index,1)
    }

    //在.html实现内容,其中sex为自定义管道
    <table border="1" [width]="100">
    <tbody>
        <tr *ngIf="emplist.length==0" >
            <td>
                no employee!!
            </td>
            <td>
                <button> add </button>
            </td>
        </tr>
        <tr *ngFor="let e of emplist;index as i">
            <td>{{e.eid}}</td>
            <td>{{e.ename}}</td>
            <td>{{e.sex}}</td>
            <td>{{e.sex| sex : 'en'}}  </td><!--使用冒号给管道传参-->
            <td>{{e.salay}}</td>
            <td>
                <button (click)="doDelete(i)">Delete</button>
            </td>
        </tr>
    </tbody>
</table>
```
###  3.2. <a name='br-1'></a>创建对象的两种方式<br>
- 方式1：手工创建式 