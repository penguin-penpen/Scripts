# Bibi's adventure #

### 需求列表 ###

上下左右、跳跃等基本按键操作
* 游戏背景（故事）
>Bibi is a special species living on a remote planet. It is born cute and has magic power. One day, it encounters the most beautiful princess on the earth, they fall in love with each other. However, the prince from another planet is jealous of Bibi and takes away the princess. To bring back his true love, Bibi decides to defeat the evil prince and save the princess.
* 三个游戏模式（单人游戏模式、多人游戏模式、自定义模式）是否需要分工
>* 单人游戏
>* 多人游戏：对抗模式、协作模式
>* 自定义模式
* 地图设计、游戏障碍设计、积分体系设计、竞技平台设计（网络）、组队系统设计
* 多操作平台

### 任务列表 ###
- [ ]游戏背景设计
- [ ]上下左右、跳跃等基本按键操作
- [ ]游戏逻辑细节设计

> 可以先设计一个简单的单人模式，三个人都大致了解了unity使用后各自负责较完整的板块

- [ ]美工

----
* 背景为一张Plane，贴背景图 Tag:'Back'

文档规范
---
> 注释

Script头部写明功能


GameObject
---

> Main Camera

* Camera
    * Background

> Background

* Tag: `Background`
* `Plane`
* Box collider
* Rigidbody
* Material

> Player

* Tag:`Player`
* `Quad`
* Box collider
* Rigidbody
* Material

> Ground

* Tag:`Ground`
* `Cube`
* Box collider
<!-- * Rigidbody -->
* Material

> deathCollider

* Tag:
* `Cube`
* Box collider
* Material

> accelerateCollider

* Tag:
* `Cube`
* Box collider
* Material

> countCollider

* Tag:
* `Cube`
* Box collider
* Material
* COUNTER:计数碰撞次数
* destroyTime:可碰撞次数

> backnforthCollider

* Tag:
* `Cube`
* Box collider
* Material
* begin, end:移动的两端点
* HALFDIS:移动的一半距离
