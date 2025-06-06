 
---

#   ASP.NET Web Forms Page Life Cycle

---

##   Objective:
Understand the **sequence of events** that occur from the time a Web Form is requested until the response is sent back to the browser.

---

##   What is the Page Life Cycle?

The **ASP.NET Page Life Cycle** refers to the **series of steps** and **events** that ASP.NET follows to **initialize**, **process**, **render**, and **unload** a web form.

---

##   Key Stages of Page Life Cycle

| Phase                | Description |
|----------------------|-------------|
| 1. Page Request       | Page requested by user; checks for cached version. |
| 2. Start              | Determines request type (new request or postback). |
| 3. Initialization     | Controls are initialized (but not loaded with data). |
| 4. Load ViewState     | ViewState data is restored to controls. |
| 5. Load PostBack Data | Postback form values are loaded. |
| 6. Load               | Page and controls load data (e.g., from DB). |
| 7. PostBack Event     | Handles events like button clicks. |
| 8. Rendering          | Page is rendered to HTML and sent to client. |
| 9. Unload             | Cleanup is done after response is sent. |

---

##   Page Life Cycle Flow (Events Sequence)

```text
Page_Request
   └─> Page_Init
        └─> InitComplete
             └─> LoadViewState
                  └─> LoadPostData
                       └─> Page_Load
                            └─> LoadComplete
                                 └─> PostBack Events (e.g., Button_Click)
                                      └─> PreRender
                                           └─> SaveViewState
                                                └─> Render
                                                     └─> Unload
```

---

##   Important Page Events Explained

| Event            | Description |
|------------------|-------------|
| `Page_PreInit`   | Set master pages or themes dynamically. |
| `Page_Init`      | Controls are initialized; good for dynamic control creation. |
| `Page_InitComplete` | Marks completion of Init phase. |
| `Page_Load`      | Load data into controls. Check `IsPostBack`. |
| `Control Events` | e.g., Button clicks, TextChanged. |
| `Page_PreRender` | Final chance to make changes before rendering. |
| `Page_Unload`    | Cleanup resources (not for updating UI). |

---

##   Code Example: Hooking Into Events

```csharp
protected void Page_PreInit(object sender, EventArgs e)
{
    // Set theme or master page
}

protected void Page_Init(object sender, EventArgs e)
{
    // Create dynamic controls
}

protected void Page_Load(object sender, EventArgs e)
{
    if (!IsPostBack)
    {
        // Load data for first time
    }
}

protected void btnSubmit_Click(object sender, EventArgs e)
{
    // Handle button click
}

protected void Page_PreRender(object sender, EventArgs e)
{
    // Final changes to controls
}

protected void Page_Unload(object sender, EventArgs e)
{
    // Clean up resources
}
```

---

##   Key Concepts

| Term | Description |
|------|-------------|
| `IsPostBack` | Checks if the page is being loaded for the first time or due to a postback. |
| `ViewState`  | Maintains state of controls between postbacks. |
| `Control Events` | Only fire after `Load` and before `PreRender`. |

---

##   Summary Table

| Stage            | Main Task                              |
|------------------|-----------------------------------------|
| Start            | Determine request/postback              |
| Init             | Instantiate and initialize controls     |
| LoadViewState    | Restore control state                   |
| LoadPostData     | Apply posted data                       |
| Load             | Page logic, bind controls               |
| Postback Events  | Event handling (clicks, etc.)           |
| PreRender        | Final updates before HTML output        |
| SaveViewState    | Save control state for next request     |
| Render           | Generate HTML                           |
| Unload           | Clean up                                |

---
 
