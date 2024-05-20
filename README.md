# Contact Database Application

This is a simple contact database application built with ASP.NET MVC. It allows users to create, read, update, and delete contacts.

## Features

- Create new contacts with name and email
- View a list of all contacts
- View details of a specific contact
- Edit the details of a specific contact
- Delete a specific contact

## Installation

1. Clone this repository
2. Open the solution in Visual Studio
3. Build the solution to restore NuGet packages
4. Run the application

## Usage

Navigate to the `/User` route to start managing contacts.

## Deployment

This application can be deployed to Azure using an Azure Resource Manager (ARM) template. The `deploy.json` and `deploy.parameters.json` files in the root of this repository define the resources needed for this application.

To deploy the application:

1. Install the [Azure CLI](https://docs.microsoft.com/cli/azure/install-azure-cli)
2. Log in to your Azure account with `az login`
3. Create a resource group with `az group create --name <ResourceGroupName> --location <Location>`
4. Deploy the application with `az deployment group create --resource-group <ResourceGroupName> --template-file deploy.json --parameters deploy.parameters.json`

## CI/CD

This repository uses GitHub Actions for continuous integration and deployment. The workflow is defined in the `.github/workflows/main.yml` file. It builds the application, runs tests, and deploys to Azure whenever changes are pushed to the main branch.

## Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## License

[MIT](https://choosealicense.com/licenses/mit/)
