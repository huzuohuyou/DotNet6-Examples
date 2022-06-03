## ����swaggerע��
- ��Ŀ���ù�ѡ���ĵ��ļ���
![](https://img2022.cnblogs.com/blog/599607/202206/599607-20220603200447450-930791831.png)

- �����ĵ��ļ�
```
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "������ѯ˵��", Version = "v2" });
    //��������ע�͹���
     var basePath = AppContext.BaseDirectory;
    var xmlPath = Path.Combine(basePath, "ReDocExample.xml");
    c.IncludeXmlComments(xmlPath, true);
});
```

## ��ӽӿ�ע�ͼ�ProducesResponseType
- ���Remarksע�ͣ����Ը���ϸ�����ĵ�����
- ProducesResponseType�����õ����߸�����ӿڲ�ͬ״̬�·��صĽӿ����ݸ�ʽ
![](https://img2022.cnblogs.com/blog/599607/202206/599607-20220603200955066-23629068.png)

## swagger.jsonתswagger.yaml
- https://oktools.net/json2yaml
ʹ�����Ϲ��߽�swagger.jsonתΪopenapi.yaml�ļ�
## ������Redoc �ĵ�����

1. Github��clone Redoc��Ŀ

Redoc��ַ�� https://github.com/Redocly/redoc

2. �� openapi.yaml ���Ƶ�demoĿ¼��

![](https://img2022.cnblogs.com/blog/599607/202206/599607-20220603202743705-1787887003.png)

3. ����npm run start 
![](https://img2022.cnblogs.com/blog/599607/202206/599607-20220603202710728-1963726427.png)

4. RedocЧ��
- �������ĵ���ʽ
![](https://img2022.cnblogs.com/blog/599607/202206/599607-20220603202843014-11042655.png)

