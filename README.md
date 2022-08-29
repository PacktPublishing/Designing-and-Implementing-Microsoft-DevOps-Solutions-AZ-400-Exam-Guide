# Designing and Implementing Microsoft DevOps Solutions AZ-400 Exam Guide

<a href="https://www.packtpub.com/product/designing-and-implementing-microsoft-devops-solutions-az-400-exam-guide-second-edition/9781803240664"><img src="https://images-na.ssl-images-amazon.com/images/I/51p9hr-HCeL._SX404_BO1,204,203,200_.jpg" alt="Book Name" height="256px" align="right"></a>

This is the code repository for [Designing and Implementing Microsoft DevOps Solutions AZ-400 Exam Guide](https://www.packtpub.com/product/designing-and-implementing-microsoft-devops-solutions-az-400-exam-guide-second-edition/9781803240664), published by Packt.

**Prepare for the certification exam and successfully apply Azure DevOps strategies with practical labs**

## What is this book about?
The AZ-400 Designing and Implementing Microsoft DevOps Solutions certification helps DevOps engineers and administrators get to grips with practices such as continuous integration and continuous delivery (CI/CD), containerization, and zero downtime deployments using Azure DevOps Services.
This new edition is updated with advanced topics such as site reliability engineering (SRE), continuous improvement, and planning your cloud transformation journey.

This book covers the following exciting features: 
* Get acquainted with Azure DevOps Services and DevOps practices
* Discover how to efficiently implement CI/CD processes
* Build and deploy a CI/CD pipeline with automated testing on Azure
* Integrate security and compliance in pipelines
* Understand and implement Azure Container Services
* Apply continuous improvement strategies to deliver innovation at scale

If you feel this book is for you, get your [copy](https://www.amazon.com/Designing-Implementing-Microsoft-DevOps-Solutions/dp/1803240660) today!

<a href="https://www.packtpub.com/?utm_source=github&utm_medium=banner&utm_campaign=GitHubBanner"><img src="https://raw.githubusercontent.com/PacktPublishing/GitHub/master/GitHub.png" alt="https://www.packtpub.com/" border="5" /></a>

## Instructions and Navigations
All of the code is organized into folders. For example, Chapter05.

The code will look like the following:
```
trigger:
- main

pool:
   name: Azure Pipelines
   vmImage: windows-2019
   
steps:
- task: DotNetCoreCLI@2
  displayName: 'dotnet build'
  inputs:
      projects: '**/*.csproj'
- task: DotNetCoreCLI@2
    displayName: 'dotnet test'
    inputs:
        command: test
        projects: '**/*.csproj'

```

**Following is what you need for this book:**
The book is for anyone looking to prepare for the AZ-400 certification exam. Software developers, application developers, and IT professionals who want to implement DevOps practices for the Azure cloud will also find this book helpful. Familiarity with Azure DevOps basics, software development, and development practices is recommended but not necessary.

With the following software and hardware list you can run all code files present in the book (Chapter 1-18).

### Software and Hardware List

| Chapter  | Software required                                                  | OS required                       |
| -------- | -------------------------------------------------------------------| ----------------------------------|
| 1-18     | Azure Account, Azure DevOps Subcription, Visual Studio Code, Git   | Windows, Mac OS X, and Linux (Any)|
| 16       | Visual Studio 2019 or 2022                                         | Windows, Mac OS X                 |



We also provide a PDF file that has color images of the screenshots/diagrams used in this book. [Click here to download it](https://packt.link/OADjU).

### Related products <Other books you may enjoy>
* Azure DevOps Explained [[Packt]](https://www.packtpub.com/product/azure-devops-explained/9781800563513) [[Amazon]](https://www.amazon.com/Azure-DevOps-Explained-started-practices/dp/1800563515)

* Learning DevOps - Second Edition [[Packt]](https://www.packtpub.com/product/learning-devops-second-edition/9781801818964) [[Amazon]](https://www.amazon.com/Learning-DevOps-comprehensive-accelerating-Kubernetes-ebook/dp/B09TBBJ787)

## Get to Know the Authors
**Subhajit Chatterjee**
He has a Bachelor of Engineering and a graduate diploma on Information Technology. He has also taken up many online certifications that has helped him learn and grow as a software engineering professional.
He has close to two decades of exposure to designing, implementing, and managing software development projects, using Microsoft & Open-Source technologies. He is a seasoned Engineering leader and has delivered many large and complex projects in Azure, IoT, Enterprise Integrations, Web Applications and Mobility space.

**Henry Been**
He has been working in IT for over ten years. He is an independent architect, developer, and trainer in a number of companies. With many of these companies, he has embarked on a journey implementing practices such as continuous integration and deployment, infrastructure as code, trunk-based development, and implementing feedback loops. Alongside his work, he creates online training courses for A Cloud Guru, and frequently speaks at meetups and conferences. He was awarded the Microsoft MVP award in 2019.

**Swapneel Deshpande**
He  is a Solution Architect, Development Consultant, and a Trusted Technology Advisor, entrepreneur, start-up consultant and more. He is working in IT for nearly 2 decades with expertise in .NET and web-related technologies. He has led the software architecture design, development, and delivery of large, complex solutions. He is passionate about embracing new technologies and teaching. He is currently working with Microsoft and his current role involves leading large and complex projects right from architecture to delivery.

**Maik van der Gaag**
He is an architect and trainer at 3fifty, an experienced consultancy company with a strong focus on the Microsoft cloud. He has over 15 years' experience of providing architecture, development, training, and design expertise. During his career, he has worked on a variety of projects, ranging from cloud transformations to DevOps implementations.
He loves to share his knowledge, which was also one of the reasons why he founded the Dutch Cloud meetup. Maik is a public speaker, writes blogs, and organizes events.
