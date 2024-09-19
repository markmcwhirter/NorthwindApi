NorthwindApi
│
└── Features
    └── Products
    	├── Commands
	    │   ├── CreateProductCommand.cs
	    │   └── UpdateProductCommand.cs
	    ├── Queries
		│   └── GetProductByIdQuery.cs
		├── Endpoints
        |   ├── CreateProductEndpoint.cs
		|	└── UpdateProductEndpoint.cs
	    │
		├── Handlers
        │	├── ProductCommandHandler.cs
		│	└── ProductQueryHandler.cs
		│
		├── Validators
		│   ├── CreateProductCommandValidator.cs
		│   ├── UpdateProductCommandValidator.cs
		│   └── GetProductByIdQueryValidator.cs
		│
		├── Models
		│   └── Product.cs
		└── Program.cs
