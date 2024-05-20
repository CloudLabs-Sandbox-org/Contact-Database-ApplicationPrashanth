[TestFixture]
public class UserControllerTests
{
    private Mock<IUserRepository> _mockRepo;
    private UserController _controller;

    [SetUp]
    public void SetUp()
    {
        _mockRepo = new Mock<IUserRepository>();
        _controller = new UserController(_mockRepo.Object);
    }

    [Test]
    public void Index_ReturnsViewWithUsers()
    {
        var users = new List<User> { new User { Id = 1, Name = "Test User" } };
        _mockRepo.Setup(repo => repo.GetAll()).Returns(users);

        var result = _controller.Index() as ViewResult;
        var model = result.Model as List<User>;

        Assert.AreEqual(users, model);
    }

    [Test]
    public void Details_ReturnsViewWithUser()
    {
        var user = new User { Id = 1, Name = "Test User" };
        _mockRepo.Setup(repo => repo.Get(1)).Returns(user);

        var result = _controller.Details(1) as ViewResult;
        var model = result.Model as User;

        Assert.AreEqual(user, model);
    }

    // Add more tests for Create, Edit, Delete methods
}

