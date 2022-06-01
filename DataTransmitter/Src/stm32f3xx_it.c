/* USER CODE BEGIN Header */
/**
  ******************************************************************************
  * @file    stm32f3xx_it.c
  * @brief   Interrupt Service Routines.
  ******************************************************************************
  * @attention
  *
  * <h2><center>&copy; Copyright (c) 2022 STMicroelectronics.
  * All rights reserved.</center></h2>
  *
  * This software component is licensed by ST under BSD 3-Clause license,
  * the "License"; You may not use this file except in compliance with the
  * License. You may obtain a copy of the License at:
  *                        opensource.org/licenses/BSD-3-Clause
  *
  ******************************************************************************
  */
/* USER CODE END Header */

/* Includes ------------------------------------------------------------------*/
#include "main.h"
#include "stm32f3xx_it.h"
/* Private includes ----------------------------------------------------------*/
/* USER CODE BEGIN Includes */
/* USER CODE END Includes */

/* Private typedef -----------------------------------------------------------*/
/* USER CODE BEGIN TD */

/* USER CODE END TD */

/* Private define ------------------------------------------------------------*/
/* USER CODE BEGIN PD */

/* USER CODE END PD */

/* Private macro -------------------------------------------------------------*/
/* USER CODE BEGIN PM */

/* USER CODE END PM */

/* Private variables ---------------------------------------------------------*/
/* USER CODE BEGIN PV */
uint8_t DMA_index = 0;

uint8_t USART_index = 0;
//uint16_t counter_DMA1_AVG_results = 0;

uint32_t ADC1_Result_AVG[NUMBER_OF_ADC_CHANNELS];
/* USER CODE END PV */

/* Private function prototypes -----------------------------------------------*/
/* USER CODE BEGIN PFP */
extern void clearBuff(uint8_t* array);
extern void USART_Tx (uint8_t* byte, uint16_t size);
/* USER CODE END PFP */

/* Private user code ---------------------------------------------------------*/
/* USER CODE BEGIN 0 */

/* USER CODE END 0 */

/* External variables --------------------------------------------------------*/

/* USER CODE BEGIN EV */
extern uint16_t ADC1_Result_Var[NUMBER_OF_ADC_CHANNELS];

extern uint8_t Tx_Buffer[3];
extern uint8_t Rx_Buffer[2];
/* USER CODE END EV */

/******************************************************************************/
/*           Cortex-M4 Processor Interruption and Exception Handlers          */ 
/******************************************************************************/
/**
  * @brief This function handles Non maskable interrupt.
  */
void NMI_Handler(void)
{
  /* USER CODE BEGIN NonMaskableInt_IRQn 0 */

  /* USER CODE END NonMaskableInt_IRQn 0 */
  /* USER CODE BEGIN NonMaskableInt_IRQn 1 */

  /* USER CODE END NonMaskableInt_IRQn 1 */
}

/**
  * @brief This function handles Hard fault interrupt.
  */
void HardFault_Handler(void)
{
  /* USER CODE BEGIN HardFault_IRQn 0 */

  /* USER CODE END HardFault_IRQn 0 */
  while (1)
  {
    /* USER CODE BEGIN W1_HardFault_IRQn 0 */
    /* USER CODE END W1_HardFault_IRQn 0 */
  }
}

/**
  * @brief This function handles Memory management fault.
  */
void MemManage_Handler(void)
{
  /* USER CODE BEGIN MemoryManagement_IRQn 0 */

  /* USER CODE END MemoryManagement_IRQn 0 */
  while (1)
  {
    /* USER CODE BEGIN W1_MemoryManagement_IRQn 0 */
    /* USER CODE END W1_MemoryManagement_IRQn 0 */
  }
}

/**
  * @brief This function handles Pre-fetch fault, memory access fault.
  */
void BusFault_Handler(void)
{
  /* USER CODE BEGIN BusFault_IRQn 0 */

  /* USER CODE END BusFault_IRQn 0 */
  while (1)
  {
    /* USER CODE BEGIN W1_BusFault_IRQn 0 */
    /* USER CODE END W1_BusFault_IRQn 0 */
  }
}

/**
  * @brief This function handles Undefined instruction or illegal state.
  */
void UsageFault_Handler(void)
{
  /* USER CODE BEGIN UsageFault_IRQn 0 */

  /* USER CODE END UsageFault_IRQn 0 */
  while (1)
  {
    /* USER CODE BEGIN W1_UsageFault_IRQn 0 */
    /* USER CODE END W1_UsageFault_IRQn 0 */
  }
}

/**
  * @brief This function handles System service call via SWI instruction.
  */
void SVC_Handler(void)
{
  /* USER CODE BEGIN SVCall_IRQn 0 */

  /* USER CODE END SVCall_IRQn 0 */
  /* USER CODE BEGIN SVCall_IRQn 1 */

  /* USER CODE END SVCall_IRQn 1 */
}

/**
  * @brief This function handles Debug monitor.
  */
void DebugMon_Handler(void)
{
  /* USER CODE BEGIN DebugMonitor_IRQn 0 */

  /* USER CODE END DebugMonitor_IRQn 0 */
  /* USER CODE BEGIN DebugMonitor_IRQn 1 */

  /* USER CODE END DebugMonitor_IRQn 1 */
}

/**
  * @brief This function handles Pendable request for system service.
  */
void PendSV_Handler(void)
{
  /* USER CODE BEGIN PendSV_IRQn 0 */

  /* USER CODE END PendSV_IRQn 0 */
  /* USER CODE BEGIN PendSV_IRQn 1 */

  /* USER CODE END PendSV_IRQn 1 */
}

/**
  * @brief This function handles System tick timer.
  */
void SysTick_Handler(void)
{
  /* USER CODE BEGIN SysTick_IRQn 0 */

  /* USER CODE END SysTick_IRQn 0 */
  
  /* USER CODE BEGIN SysTick_IRQn 1 */

  /* USER CODE END SysTick_IRQn 1 */
}

/******************************************************************************/
/* STM32F3xx Peripheral Interrupt Handlers                                    */
/* Add here the Interrupt Handlers for the used peripherals.                  */
/* For the available peripheral interrupt handler names,                      */
/* please refer to the startup file (startup_stm32f3xx.s).                    */
/******************************************************************************/

/**
  * @brief This function handles DMA1 channel1 global interrupt.
  */
void DMA1_Channel1_IRQHandler(void)
{
  /* USER CODE BEGIN DMA1_Channel1_IRQn 0 */
  if (LL_DMA_IsActiveFlag_TC1(DMA1) != RESET)
  {
    LL_DMA_ClearFlag_TC1(DMA1);
        
    //static uint8_t DMA_index = 0; 
    /*
    counter_DMA1_AVG_results++;
    
    for (uint8_t i = 0; i < NUMBER_OF_ADC_CHANNELS; i++)
    {
      ADC1_Result_AVG[i] += ADC1_Result_Var[i];
    }
    
    if (counter_DMA1_AVG_results == 8)
    {
      for (uint8_t i = 0; i < NUMBER_OF_ADC_CHANNELS; i++)
      {
        ADC1_Result_AVG[i] >>= 3;
      }
      ADC1_Result_AVG[NUMBER_OF_ADC_CHANNELS] = 8;
      counter_DMA1_AVG_results = 0;
    }*/
         
  }
  /* USER CODE END DMA1_Channel1_IRQn 0 */
  
  /* USER CODE BEGIN DMA1_Channel1_IRQn 1 */

  /* USER CODE END DMA1_Channel1_IRQn 1 */
}

/**
  * @brief This function handles USART1 global interrupt / USART1 wake-up interrupt through EXTI line 25.
  */
void USART1_IRQHandler(void)
{
  /* USER CODE BEGIN USART1_IRQn 0 */
  if(LL_USART_IsActiveFlag_RXNE(USART1) != RESET)
  {
    Rx_Buffer[USART_index] = LL_USART_ReceiveData8(USART1);
    
    if (Rx_Buffer[0] == 0x55 && Rx_Buffer[1] == 0x96)
    {
      LL_TIM_EnableIT_UPDATE(TIM7);
      LL_TIM_EnableCounter(TIM7);
    }
    else if (Rx_Buffer[0] == 0xAA && Rx_Buffer[1] == 0x96)
    {  
      LL_TIM_DisableIT_UPDATE(TIM7);
      LL_TIM_DisableCounter(TIM7);
      LL_TIM_SetCounter(TIM7, 0);
    }
    
    if (USART_index == 1)
    {
      clearBuff(Rx_Buffer);
    }

    USART_index = USART_index < NUMBER_OF_ADC_CHANNELS - 1 ? USART_index + 1 : 0;
  }
  else
  {
    if(LL_USART_IsActiveFlag_ORE(USART1))
    {
      (void) USART1->RDR;
    }
    else if(LL_USART_IsActiveFlag_FE(USART1))
    {
      (void) USART1->RDR;
    }
    else if(LL_USART_IsActiveFlag_NE(USART1))
    {
      (void) USART1->RDR;
    }
  }
  /* USER CODE END USART1_IRQn 0 */
  /* USER CODE BEGIN USART1_IRQn 1 */

  /* USER CODE END USART1_IRQn 1 */
}

/**
  * @brief This function handles Timer 6 interrupt and DAC underrun interrupts.
  */
void TIM6_DAC_IRQHandler(void)
{
  /* USER CODE BEGIN TIM6_DAC_IRQn 0 */
  if (LL_TIM_IsActiveFlag_UPDATE(TIM6) != RESET)
  {
    LL_TIM_ClearFlag_UPDATE(TIM6);
    
    //LL_USART_IsActiveFlag_RXNE(USART1);
    
    LL_ADC_REG_StartConversion(ADC1);
  }
  /* USER CODE END TIM6_DAC_IRQn 0 */
  
  /* USER CODE BEGIN TIM6_DAC_IRQn 1 */

  /* USER CODE END TIM6_DAC_IRQn 1 */
}

/**
  * @brief This function handles TIM7 global interrupt.
  */
void TIM7_IRQHandler(void)
{
  /* USER CODE BEGIN TIM7_IRQn 0 */
  if (LL_TIM_IsActiveFlag_UPDATE(TIM7) != RESET)
  {
    LL_TIM_ClearFlag_UPDATE(TIM7);
    
    Tx_Buffer[0] = ADC1_Result_Var[DMA_index] >> 8;
    Tx_Buffer[1] = ADC1_Result_Var[DMA_index] & 0x00FF;
    Tx_Buffer[2] = 0x9 << 4 | DMA_index + 1;
    
    USART_Tx((uint8_t*)Tx_Buffer, 3); 
        
    DMA_index = DMA_index < NUMBER_OF_ADC_CHANNELS - 1 ? DMA_index + 1 : 0;
  }
  /* USER CODE END TIM7_IRQn 0 */
  /* USER CODE BEGIN TIM7_IRQn 1 */

  /* USER CODE END TIM7_IRQn 1 */
}

/* USER CODE BEGIN 1 */

/* USER CODE END 1 */
/************************ (C) COPYRIGHT STMicroelectronics *****END OF FILE****/
