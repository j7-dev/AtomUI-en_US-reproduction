## BUG 描述：

配置為簡體中文 `builder.WithDefaultLanguageVariant(LanguageVariant.zh_CN);` 正常
<img width="1920" height="1032" alt="Image" src="https://github.com/user-attachments/assets/bc27caaa-a527-4aef-91c8-b1348b53ed5f" />

如果配置為英文 `builder.WithDefaultLanguageVariant(LanguageVariant.en_US);` 英文字串會出不來
<img width="1920" height="1032" alt="Image" src="https://github.com/user-attachments/assets/d48476ed-c5cc-421c-b6aa-a1d6e143847b" />

## 重現步驟

clone 此專案啟動可重現此問題

https://github.com/j7-dev/AtomUI-en_US-reproduction

### 系統訊息
<img width="1300" height="900" alt="Image" src="https://github.com/user-attachments/assets/64f20370-1c03-4f97-8cf2-4473a2d9ba92" />

### 依賴清單
<img width="1920" height="1032" alt="Image" src="https://github.com/user-attachments/assets/6c2eb061-a62e-4b57-ba61-a22655930197" />