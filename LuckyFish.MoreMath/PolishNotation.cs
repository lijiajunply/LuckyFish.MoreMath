namespace LuckyFish.MoreMath;

public class PolishNotation
{
	public double Opertion(string expr)
	{
		double d = 0;
		return d;
	}
}

/*
 System.out.println("请输入计算表达式：");
		Scanner sc = new Scanner(System.in);
		String input = sc.nextLine();
		sc.close();
		
		StringBuilder sb = new StringBuilder();
		//创建运算符栈
		Stack<Character> opStack = new Stack();
		//设定运算符优先级
		Map<Character,Integer> opMap = new HashMap();
		opMap.put('(', 0);
		opMap.put('+', 1);
		opMap.put('-', 1);
		opMap.put('*', 2);
		opMap.put('/', 2);
		
		//处理字符串
		for(int i =0;i<input.length();i++){
			//如果是'('直接压栈
			if(input.charAt(i) == '('){
				opStack.push('(');
				//如果是运算符
			}else if(isOperator(input.charAt(i))){
				char curOp = input.charAt(i);
				//如果运算符栈是空，就直接压栈
				if(opStack.isEmpty())
					opStack.push(curOp);
				//运算符栈不为空，且当当前运算符的优先级比栈内第一个运算符的优先级高的时候，压栈
				else if(opMap.get(curOp) > opMap.get(opStack.peek()))
					opStack.push(curOp);
				else{
				//栈不为空，且运算符的优先级小于等于栈顶元素
				for(int j = 0;j<=opStack.size();j++){
					//弹出栈内第一个元素
					char ch = opStack.pop();
					sb.append(ch + "");
					if(opStack.isEmpty()){
						opStack.push(curOp);
						break;
					}else if(opMap.get(curOp) > opMap.get(opStack.peek())){
                        opStack.push(curOp);
                        break;
                    }					
				}
			}
		}else if(input.charAt(i) == ')'){//如果是')'就把站內'('上的元素都弹出栈
			for(int j = 0;j<=opStack.size();j++){
				char c = opStack.pop();
				if(c == '(')
					break;
				else
					sb.append(c + "");
			}
		}else{
			sb.append(input.charAt(i)+"");
		}
	}
		//把栈内剩余的运算符都弹出栈
		for(int i = 0;i<=opStack.size();i++){
			sb.append(opStack.pop()+"");
		}
		System.out.println(sb);
}

	private static boolean isOperator(char charAt) {
		if(charAt == '+'||charAt=='-'||charAt=='*'||charAt=='/')
			return true;
		return false;
	}
*/