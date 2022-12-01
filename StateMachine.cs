
public class Food { }

public enum SnakeState
{
	Idle, Moving, Eating,
}

public class Snake
{
	private Food m_targetFood = null;
	private SnakeState m_state = SnakeState.Idle;
	private Dictionary<SnakeState, BaseSnakeState> m_states = new Dictionary<SnakeState, BaseSnakeState>();

	public Snake()
	{
		m_states.Add(SnakeState.Idle, new SnakeIdleState(this));
		m_states.Add(SnakeState.Moving, new SnakeMoveState(this));
		m_states.Add(SnakeState.Eating, new SnakeEatState(this));
	}

	public void ChangeState(SnakeState state)
	{
		m_state = state;
	}

	public void FindFood()
	{
		m_targetFood = new Food();
		ChangeState(SnakeState.Moving);
	}

	public void Move()
	{
		ChangeState(SnakeState.Eating);
	}

	public void Eat()
	{
		m_targetFood = null;
		ChangeState(SnakeState.Idle);
	}

	public void Update()
	{
		m_states[m_state].Update();
	}

	public void Rain()
	{
		m_states[m_state].Rain();
	}
}


public abstract class BaseSnakeState
{
	protected readonly Snake m_snake;
	public BaseSnakeState(Snake snake)
	{
		m_snake = snake;
	}

	public abstract void Update();
	public abstract void Rain();
}

public class SnakeIdleState : BaseSnakeState
{
	public SnakeIdleState(Snake snake) : base(snake) { }

	public override void Update()
	{
		m_snake.FindFood();
	}

	public override void Rain()
	{
	}
}


public class SnakeMoveState : BaseSnakeState
{
	public SnakeMoveState(Snake snake) : base(snake) { }

	public override void Update()
	{
		m_snake.Move();
	}

	public override void Rain()
	{
		m_snake.ChangeState(SnakeState.Idle);
	}
}


public class SnakeEatState : BaseSnakeState
{
	public SnakeEatState(Snake snake) : base(snake) { }

	public override void Update()
	{
		m_snake.Eat();
	}

	public override void Rain()
	{
		m_snake.ChangeState(SnakeState.Idle);
	}
}