#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main() {
    char input[100];
    int num1, num2;
    char operator;

    printf("请输入一个表达式（例如 242+234）：");
    scanf("%s", input);

    // 使用 sscanf 函数来解析输入的字符串
    sscanf(input, "%d%c%d", &num1, &operator, &num2);

    switch (operator) {
        case '+':
            printf("%d %c %d = %d\n", num1, operator, num2, num1 + num2);
            break;
        case '-':
            printf("%d %c %d = %d\n", num1, operator, num2, num1 - num2);
            break;
        case '*':
            printf("%d %c %d = %d\n", num1, operator, num2, num1 * num2);
            break;
        case '/':
            if (num2 == 0) {
                printf("除数不能为 0\n");
            } else {
                printf("%d %c %d = %d\n", num1, operator, num2, num1 / num2);
            }
            break;
        default:
            printf("无效的运算符\n");
    }
    return 0;
}