# LongestIncreasingSubsequence
This LIS Application takes one string input of any number of integers separated by single whitespace and outputs the longest increasing subsequence (increased by any number) present in that sequence in other words it is a subsequencearray. If more than 1 sequence exists with the longest length, it output the earliest one.

# For Example

Input : 
6 1 5 9 2

Output : 
1 5 9

Input : 
6 2 4 6 1 5 9 2

Output : 
2 4 6

# Development Environment

Visual Studio 2022 is used for Primary Development of this application.

C# .NET Core 6 framework with TDD approach is used to built the functionality.

Microsoft.VisualStudio.Azure.Containers.Tools.Targets v1.17.0

xunit v2.4.1 

FluentAssertions v6.7.0

Microsft.NET.Test.Sdk 17.1.0

To be able to run tests and linting in a developer machine, docker-compose service is used, so that they don't have any dependency on the host machine. For example, this can be run like docker-compose run test and that should execute all the 15 test cases described in the Test Project.
https://hub.docker.com/repository/docker/rohitnarkhede109/longestincreasingsubsequence

# Continuous Integration

Buddy CI/CD pipeline is integrated with this project that executes all the tests and checks linting and performs Deployments for the project and runs the tests in Docker image.

![VS Unit Test Cases Execution](https://user-images.githubusercontent.com/10917456/187227633-4a79d113-bac0-40d4-8243-dff0f01d2d1e.JPG)

![Intermediate Progress during Deployment](https://user-images.githubusercontent.com/10917456/187227624-b567b73f-280b-45d1-a2e9-794b181acff6.JPG)

![Buddy CICD Showing All Tests Passed in Pipeline Actions](https://user-images.githubusercontent.com/10917456/187227586-8edcc236-bfdf-41dc-b429-2b758a822533.JPG)

![Buddy Piepline Setup DotNet Actions](https://user-images.githubusercontent.com/10917456/187227599-da164220-8ff1-4cbf-9afc-8111bdf9d3f5.JPG)

![Buddy Pipeline Setup Docker Actions](https://user-images.githubusercontent.com/10917456/187227606-608e9153-4509-4bd3-b028-f93709f83852.JPG)

![DockerHub Showing Container Image](https://user-images.githubusercontent.com/10917456/187227612-784e0d22-f1cd-43ed-9403-89241b0239f2.JPG)

